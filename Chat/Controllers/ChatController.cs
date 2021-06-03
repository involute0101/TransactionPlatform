using Chat;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Chat
{
    [ApiController]
    [Route("[controller]")]
    public class ChatController : ControllerBase
    {
        private OneToOneHub oneToOneHub = new OneToOneHub();

        [HttpGet]
        public String Test()
        {
            oneToOneHub.OnConnected();
            String str = "现在：" + oneToOneHub.GetUsers()+"\n";
            oneToOneHub.SendMessage(GetIp(), "你好");
            return str;
        }

        private String GetIp()
        {
            string AddressIP = string.Empty;
            foreach (IPAddress _IPAddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (_IPAddress.AddressFamily.ToString() == "InterNetwork")
                {
                    AddressIP = _IPAddress.ToString();
                }
            }
            return AddressIP;
        }
    }
}
