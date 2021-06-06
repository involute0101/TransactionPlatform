using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WinForm.Tool;
using static WinForm.Tool.Client;

namespace WinForm.Service
{
    class ClientService
    {
        Client client;
        private string ServerAddress = "http://localhost:5001/";

        //唤醒服务器
        public bool notifyServer()
        {
            string baseUrl = ServerAddress + "Server/notify";
            HttpClient client = new HttpClient();
            var task = client.GetStringAsync(baseUrl);
            try
            {
                Convert.ToString(task.Result).Equals("Start success");
                return true;
            }catch(Exception e)
            {
                Console.WriteLine("错误信息：" + e);
                return false;
            }
        }    

        //连接服务器，绑定动态的ip端口
        public void connectServer(PrintImage printImage ,Print ClientPrint)
        {
            if (client == null) client = new Client(printImage,ClientPrint, "127.0.0.1", "37280");
            if (!client.connected) client.start();
            StaticVar.LOCALIPPORT = client.localIpPort;
        }

        //发送文本信息
        public void sendMessage(string info)
        {
            if (client != null && client.connected)client.Send(info);
        }

        //发送图片
        public void sendImage(string fileName)
        {
            client.SendImage(fileName);
        }

        public void stopConnect()
        {
            client.stop();
        }
    }
}
