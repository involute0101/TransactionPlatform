using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace WebApi
{
    public class Server
    {
        public string ipString = "127.0.0.1";   // 服务器端ip
        public int port = 37280;                // 服务器端口

        public Socket socket;
        public Print print;                     // 运行时的信息输出方法

        public Dictionary<string, Socket> clients = new Dictionary<string, Socket>();   // 存储连接到服务器的客户端信息
        public bool started = false;            // 标识当前是否启动了服务

        public Server(Print print = null, string ipString = null, int port = -1)        //传入数字的构造函数
        {
            this.print = print;
            if (ipString != null) this.ipString = ipString;
            if (port >= 0) this.port = port;
        }

        public Server(Print print = null, string ipString = null, string port = "-1")    //传入字符串的构造函数
        {
            this.print = print;
            if (ipString != null) this.ipString = ipString;

            int port_int = Int32.Parse(port);
            if (port_int >= 0) this.port = port_int;
        }

        /// Print用于输出Server的输出信息
        public delegate void Print(string info);

        /// 启动服务
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

        /// 监听客户端的连接
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
                new Thread(receiveData).Start(clientScoket);   // 在新的线程中接收客户端信息

                Thread.Sleep(1000);                            // 延时1秒后，接收连接请求
                if (!started) return;
            }
        }

        /// 发送信息
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

        /// 通过socket发送数据data
        private void Send(Socket socket, string data)
        {
            if (socket != null && data != null && !data.Equals(""))
            {
                byte[] bytes = Encoding.UTF8.GetBytes(data);   // 将data转化为byte数组
                socket.Send(bytes);                            // 
            }
        }

        /// 接收通过socket发送过来的数据
        private void receiveData(object obj)
        {
            Socket socket = (Socket)obj;

            string clientIp = socket.RemoteEndPoint.ToString();                 // 获取客户端标识 ip和端口
            Console.WriteLine("测试：" + clientIp);
            if (!clients.ContainsKey(clientIp)) clients.Add(clientIp, socket);  // 将连接的客户端socket添加到clients中保存
            else clients[clientIp] = socket;

            while (true)
            {
                try
                {
                    string str = Receive(socket);
                    if (!str.Equals(""))
                    {
                        if (print != null) print("【" + clientIp + "】" + str);

                        if (str.Equals("[.Shutdown]")) Environment.Exit(0); // 服务器退出                  
                    }
                }
                catch (Exception exception)
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

        /// 从socket接收数据
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
        /// 停止服务
        /// </summary>
        public void stop()
        {
            started = false;
        }
    }
}
