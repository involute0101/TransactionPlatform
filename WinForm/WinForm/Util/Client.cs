using NPOI.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WinForm.Tool
{
    //通讯客户端
    class Client
    {
        public string ipString = "127.0.0.1";   // 服务器端ip
        public int port = 37280;                // 服务器端口
        public Socket socket;
        public Print print;                     // 运行时的信息输出方法
        public PrintImage printImage;
        public bool connected = false;          // 标识当前是否连接到服务器
        public string localIpPort ;         // 记录本地ip端口信息

        public Client(PrintImage printImage = null,Print print = null, string ipString = null, int port = -1)
        {
            this.print = print;
            this.printImage = printImage;
            if (ipString != null) this.ipString = ipString;
            if (port >= 0) this.port = port;
        }

        public Client(PrintImage printImage = null,Print print = null, string ipString = null, string port = "-1")
        {
            this.print = print;
            this.printImage = printImage;
            if (ipString != null) this.ipString = ipString;

            int port_int = Int32.Parse(port);
            if (port_int >= 0) this.port = port_int;
        }


        /// <summary>
        /// Print用于输出Server的输出信息
        /// </summary>
        public delegate void Print(string info);
        public delegate void PrintImage(Image image);

        /// <summary>
        /// 启动客户端，连接至服务器
        /// </summary>
        public void start()
        {
            //设定服务器IP地址  
            IPAddress ip = IPAddress.Parse(ipString);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //修改
            /*IPAddress address = IPAddress.Parse("127.0.0.1");
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(new IPEndPoint(address, 8888));*/

            try
            {
                socket.Connect(new IPEndPoint(ip, port));   // 连接服务器
                //if (print != null) print("连接服务器【" + socket.RemoteEndPoint.ToString() + "】完成"); // 连接成功
                localIpPort = socket.LocalEndPoint.ToString();
                connected = true;

                //new Thread(receiveData).Start(socket);// 在新的线程中接收服务器信息
                if(StaticVar.INFOTYPE.Equals("Image"))
                {
                    Thread receiveImageThread = new Thread(receiveImage); //新的线程中接收图片
                    receiveImageThread.SetApartmentState(ApartmentState.STA);
                    receiveImageThread.Start(socket);
                }
                else new Thread(receiveData).Start(socket);// 在新的线程中接收文本信息

            }
            catch (Exception ex)
            {
                if (print != null) print("连接服务器失败 " + ex.ToString()); // 连接失败
                connected = false;
            }
        }

        /// <summary>
        /// 结束客户端
        /// </summary>
        public void stop()
        {
            connected = false;
        }

        /// <summary>
        /// 发送信息
        /// </summary>
        public void Send(string info)
        {
            try
            {
                Send(socket, info);
            }
            catch (Exception ex)
            {
                if (print != null) print("服务器端已断开，【" + socket.RemoteEndPoint.ToString() + "】");
            }
        }

        /// <summary>
        /// 通过socket发送数据data
        /// </summary>
        private void Send(Socket socket, string data)
        {
            if (socket != null && data != null && !data.Equals(""))
            {
                byte[] bytes = Encoding.UTF8.GetBytes(data);   // 将data转化为byte数组
                socket.Send(bytes);                            // 
            }
        }

        //发送图片
        public void SendImage(string fileName)
        {
            Image img = Image.FromFile(fileName);
            byte[] imgByte = Serialize(img);

            SendImageBytes(socket, imgByte);
        }

        //发送图片字节数组
        public void SendImageBytes(Socket socket,byte[] bytes)
        {
            if (socket != null && bytes != null)
            {             
                socket.Send(bytes);                            
            }
        }

        //接收图片
        public void receiveImage(object socket)
        {
            Socket ortherSocket = (Socket)socket;

            while (true)
            {
                try
                {
                    Image img = ReceiveimgByte(ortherSocket);       // 接收服务器端发送的信息
                    if (img!=null)
                    {
                        if (print != null) printImage(img);
                        stopConnect();
                    }
                }
                catch (Exception ex)
                {
                    //待处理
                    //if (print != null) print("连接已自动断开，" + ex.Message);
                    //ortherSocket.Shutdown(SocketShutdown.Both);
                    //ortherSocket.Close();
                    connected = false;
                    break;
                }

                if (!connected) break;
                Thread.Sleep(200);      // 延时0.2后处理接收到的信息          
            }
        }
        private Image ReceiveimgByte(Socket socket)
        {
            Image image = null;

            byte[] bytes = null;
            int len = socket.Available;
            if (len > 0)
            {
                bytes = new byte[len];
                int receiveNumber = socket.Receive(bytes);       //改
                image = (Image)Deserialize(bytes);
            }
            return image;
        }

        //序列化对象
        public byte[] Serialize(Image data)     //原来是Object参数   
        {
            /*BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream rems = new MemoryStream();
            formatter.Serialize(rems, data);
            return rems.GetBuffer();*/
            //以下为尝试
            ImageFormat format = data.RawFormat;
            using (MemoryStream ms = new MemoryStream())
            {
                if (format.Equals(ImageFormat.Jpeg))
                {
                    data.Save(ms, ImageFormat.Jpeg);
                }
                else if (format.Equals(ImageFormat.Png))
                {
                    data.Save(ms, ImageFormat.Png);
                }
                else if (format.Equals(ImageFormat.Bmp))
                {
                    data.Save(ms, ImageFormat.Bmp);
                }
                else if (format.Equals(ImageFormat.Gif))
                {
                    data.Save(ms, ImageFormat.Gif);
                }
                else if (format.Equals(ImageFormat.Icon))
                {
                    data.Save(ms, ImageFormat.Icon);
                }
                byte[] buffer = new byte[ms.Length];
                //Image.Save()会改变MemoryStream的Position，需要重新Seek到Begin
                ms.Seek(0, SeekOrigin.Begin);
                ms.Read(buffer, 0, buffer.Length);
                return buffer;

            }
        }

        //将字节反序列化成object
        public Object Deserialize(byte[] data)          
        {
            /*for (int i = 0; i < data.Length; i++) Console.Write(data[i]);
             Console.WriteLine("字节数组完毕");
             Object obj = null;
             try
             {              
                 BinaryFormatter formatter = new BinaryFormatter();
                 MemoryStream rems = new MemoryStream(data);
                 data = null;
                 obj = formatter.Deserialize(rems);
             }
             catch (Exception ex) 
             {

             }

             return obj;*/
            //以下为尝试
            MemoryStream ms = new MemoryStream(data);
            Image image = System.Drawing.Image.FromStream(ms);
            return (Object)image;

        }

        /// <summary>
        /// 接收通过socket发送过来的数据
        /// </summary>
        private void receiveData(object socket)
        {
            Socket ortherSocket = (Socket)socket;

            //if (print != null) print("receiveData:");

            while (true)
            {
                try
                {
                    String data = Receive(ortherSocket);       // 接收客户端发送的信息
                    if (!data.Equals(""))
                    {
                        //if (print != null) print("服务器" + ortherSocket.RemoteEndPoint.ToString() + "信息：\r\n" + data);
                        if (print != null) print(data);
                        stopConnect();                      
                    }
                }
                catch (Exception ex)
                {
                    //待处理
                    //if (print != null) print("连接已自动断开，" + ex.Message);
                    //ortherSocket.Shutdown(SocketShutdown.Both);
                    //ortherSocket.Close();
                    connected = false;
                    break;
                }

                if (!connected) break;
                Thread.Sleep(200);      // 延时0.2后处理接收到的信息
            }
        }

        /// <summary>
        /// 从socket接收数据
        /// </summary>
        private string Receive(Socket socket)
        {
            string data = "";

            byte[] bytes = null;
            int len = socket.Available;
            if (len > 0)
            {
                bytes = new byte[len];
                int receiveNumber = socket.Receive(bytes);
                data = Encoding.UTF8.GetString(bytes, 0, receiveNumber);
            }

            return data;
        }

        public void stopConnect()
        {
            connected = false;
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }
    }
}
