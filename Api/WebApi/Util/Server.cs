using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using WebApi.Models;
using WebApi.Tool;

namespace WebApi
{
    public class Server
    {
        // 服务器端ip
        public string ipString = "127.0.0.1";
        // 服务器端口
        public int port = 37280;                

        public Socket socket;
        // 运行时的信息输出方法
        public Print print;
        // 存储连接到服务器的客户端信息
        public Dictionary<string, Socket> clients = new Dictionary<string, Socket>();
        // 标识当前是否启动了服务
        public bool started = false;

        /// <summary>
        /// 传入数字的构造函数
        /// </summary>
        /// <param name="print"></param>
        /// <param name="ipString"></param>
        /// <param name="port"></param>
        public Server(Print print = null, string ipString = null, int port = -1) 
        {
            this.print = print;
            if (ipString != null) this.ipString = ipString;
            if (port >= 0) this.port = port;
        }

        /// <summary>
        /// 传入字符串的构造函数
        /// </summary>
        /// <param name="print"></param>
        /// <param name="ipString"></param>
        /// <param name="port"></param>
        public Server(Print print = null, string ipString = null, string port = "-1")    
        {
            this.print = print;
            if (ipString != null) this.ipString = ipString;

            int port_int = Int32.Parse(port);
            if (port_int >= 0) this.port = port_int;
        }

        // Print用于输出Server的输出信息
        public delegate void Print(string info);

        /// <summary>
        /// 启动服务
        /// </summary>
        public void start()
        {
            try
            {
                IPAddress address = IPAddress.Parse(ipString);
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Bind(new IPEndPoint(address, port));
                socket.Listen(10000);       //挂起的连接队列的最大长度

                if (print != null)
                {
                    try { print("启动服务【" + socket.LocalEndPoint.ToString() + "】成功"); }
                    catch { print = null; }
                }
                started = true;

                new Thread(listenClientConnect).Start(socket);  // 在新的线程中监听客户端连接
            }
            catch (Exception exception)
            {
                if (print != null)
                {
                    print("启动服务失败 " + exception.ToString());
                }
                started = false;
            }
        }

        /// <summary>
        /// 监听客户端的连接
        /// </summary>
        /// <param name="obj"></param>
        private void listenClientConnect(object obj)
        {
            Socket socket = (Socket)obj;
            while (true)
            {
                Socket clientScoket = socket.Accept();
                if (print != null)
                {
                    print("客户端" + clientScoket.RemoteEndPoint.ToString() + "已连接");
                }

                if(CommunicationTool.INFOTYPE.Equals("Image")) new Thread(receiveImage).Start(clientScoket);//在新的线程中接收图片
                else new Thread(receiveData).Start(clientScoket);   // 在新的线程中接收客户端信息


                Thread.Sleep(1000);                            // 延时1秒后，接收连接请求
                if (!started) return;
            }
        }

        /// <summary>
        /// 发送信息
        /// </summary>
        /// <param name="info"></param>
        /// <param name="id"></param>
        public void Send(string info, string id)
        {
            if (clients.ContainsKey(id))
            {
                Socket socket = clients[id];

                try
                {
                    Send(socket, info);
                    if (print != null) print("【 me 】:" + info);     //自己界面输出信息
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    clients.Remove(id);
                    if (print != null) print("客户端已断开，【" + id + "】");
                }
            }
        }

        /// <summary>
        /// 通过socket发送数据data
        /// </summary>
        /// <param name="socket"></param>
        /// <param name="data"></param>
        private void Send(Socket socket, string data)
        {
            if (socket != null && data != null && !data.Equals(""))
            {
                byte[] bytes = Encoding.UTF8.GetBytes(data);   // 将data转化为byte数组
                socket.Send(bytes);                            // 
            }
        }

        /// <summary>
        /// 接收通过socket发送过来的数据
        /// </summary>
        /// <param name="obj"></param>
        private void receiveData(object obj)
        {
            Socket socket = (Socket)obj;

            string clientIp = socket.RemoteEndPoint.ToString();                 // 获取客户端标识 ip和端口
            if (!clients.ContainsKey(clientIp)) clients.Add(clientIp, socket);  // 将连接的客户端socket添加到clients中保存
            else clients[clientIp] = socket;

            string goalIpPort = CommunicationTool.GOALIPPORT;  

            while (true)
            {
                try
                {
                    string str = Receive(socket);
                    if (!str.Equals(""))
                    {
                        Send(str, CommunicationTool.GOALIPPORT);      //转发信息
                    }
                }
                catch (Exception exception) //目标ip可能未连接
                {
                    if (print != null) print("连接已自动断开，【" + clientIp + "】" + exception.Message);

                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();

                    if (clients.ContainsKey(clientIp)) clients.Remove(clientIp);
                    return;
                }

                if (!started) return;
                Thread.Sleep(200);      // 延时0.2秒后再接收客户端发送的消息
            }
        }

        /// <summary>
        /// 从socket接收数据
        /// </summary>
        /// <param name="socket"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 接收图片
        /// </summary>
        /// <param name="obj"></param>
        public void receiveImage(Object obj)
        {
            Socket socket = (Socket)obj;
            string clientIp = socket.RemoteEndPoint.ToString();                 // 获取客户端标识 ip和端口
            if (!clients.ContainsKey(clientIp)) clients.Add(clientIp, socket);  // 将连接的客户端socket添加到clients中保存
            else clients[clientIp] = socket;

            string goalIpPort = CommunicationTool.GOALIPPORT;

            while (true)
            {
                try
                {                  
                    int len = socket.Available;
                    byte[] bytes = new byte[len];
                    socket.Receive(bytes);
                    if (clients.ContainsKey(CommunicationTool.GOALIPPORT))
                    {
                        Socket goalSocket = clients[CommunicationTool.GOALIPPORT];

                        try
                        {
                            if (goalSocket != null && bytes != null)
                            {
                                goalSocket.Send(bytes);           //转发图片                            
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                            clients.Remove(CommunicationTool.GOALIPPORT);
                            if (print != null) print("客户端已断开，【" + CommunicationTool.GOALIPPORT + "】");
                        }
                    }
                }
                catch { }
            }
        }

        /// <summary>
        /// 发送图片，字节数组
        /// </summary>
        /// <param name="img"></param>
        /// <param name="id"></param>
        public void sendImage(Image img,string id)
        {
            byte[] imgByte = Serialize(img);

            if (clients.ContainsKey(id))
            {
                Socket socket = clients[id];

                try
                {
                    if (socket != null && imgByte != null)
                    {                      
                        socket.Send(imgByte);           //转发图片                            
                    }                 
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    clients.Remove(id);
                    if (print != null) print("客户端已断开，【" + id + "】");
                }
            }
        }

        /// <summary>
        /// 接收图片字节数组
        /// </summary>
        /// <param name="socket"></param>
        /// <returns></returns>
        public Image receiveImageBytes(Socket socket)
        {
            Image image = null;
            byte[] bytes = null;
            int len = socket.Available;
            if (len > 0)
            {
                bytes = new byte[len];
                int receiveNumber = socket.Receive(bytes);
                image = (Image)Deserialize(bytes);
            }
            return image;
        }

        /// <summary>
        /// 序列化对象->字节数组
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public byte[] Serialize(object data)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream rems = new MemoryStream();
            formatter.Serialize(rems, data);
            return rems.GetBuffer();
        }

        /// <summary>
        /// 将字节反序列化成object
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public object Deserialize(byte[] data)
        {
            Object obj = null;
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                MemoryStream rems = new MemoryStream(data);
                data = null;
                obj = formatter.Deserialize(rems);
            }
            catch (Exception ex) { }
            return obj;
        }

        /// <summary>
        /// 停止服务
        /// </summary>
        public void stop()
        {
            started = false;
        }
    }
}
