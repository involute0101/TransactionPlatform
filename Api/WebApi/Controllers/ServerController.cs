using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebApi.Models;
using WebApi.Tool;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServerController
    {
        readonly Server server = new Server(ServerPrint, "127.0.0.1", 37280);
        private readonly TranscationContext transactionContext;

        public ServerController(TranscationContext context)       //客户端使用需要先发送一个请求，才会构造此controller，从而启动Server
        {
            transactionContext = context;
            if (!server.started) server.start();
        }

        //服务器端输出方式
        private static void ServerPrint(string info)
        {
            Console.WriteLine("收到：" + info);
        }

        //唤醒服务器
        [HttpGet("notify")]
        public String startInfo()
        {
            return "Start success";
        }

        //认证用户身份，保存IP地址和端口
        [HttpPost("identify")]
        public String ReceiveInfo([FromBody] Object body)
        {
            CommunicationEntity communication = JsonConvert.DeserializeObject<CommunicationEntity>(body.ToString());
            var communication_temp = transactionContext.CommunicationEntities.FirstOrDefault(t => t.UserId == communication.UserId);
            if (communication_temp == null)
            {
                transactionContext.CommunicationEntities.Add(communication);
                transactionContext.SaveChanges();
            }
            else
            {
                communication_temp.ipStringPort = communication.ipStringPort;
                communication_temp.goalUserId = communication.goalUserId;
                transactionContext.Entry(communication_temp).State = EntityState.Modified;
                transactionContext.SaveChanges();
            }
            CommunicationEntity goaler = transactionContext.CommunicationEntities.Where(t => t.UserId == communication.goalUserId).ToList().First();
            CommunicationTool.GOALIPPORT = goaler.ipStringPort;         //保存目标IP地址
            return "success";
        }

        //发送的聊天信息类型
        [HttpGet("infoType")]
        public String informationType(String infotype)
        {
            CommunicationTool.INFOTYPE = infotype;
            server.stop();server.start();
            return CommunicationTool.INFOTYPE;
        }

    }
}
