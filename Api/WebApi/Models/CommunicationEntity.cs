using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class CommunicationEntity
    {
        public int CommunicationEntityId { get; set; }
        //ip地址和端口
        public String ipStringPort { get; set; }   
        //用户id
        public String UserId { get; set; }          //操作中转换为int
        //通讯的目标用户iod
        public String goalUserId { get; set; } 

        public CommunicationEntity(String ipStringPort,String UserId,String goalUserId)
        {
            this.ipStringPort = ipStringPort;
            this.UserId = UserId;
            this.goalUserId = goalUserId;
        }

        public CommunicationEntity() { }
    }
}
