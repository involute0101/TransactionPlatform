using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.EntityClass
{
    public class CommunicationEntity
    {
        public int CommunicationEntityId { get; set; }

        public String ipStringPort { get; set; }

        public String UserId { get; set; }          //操作中转换为int

        public String goalUserId { get; set; }

        public CommunicationEntity(String ipStringPort, String UserId,String goalUserId)
        {
            this.ipStringPort = ipStringPort;
            this.UserId = UserId;
            this.goalUserId = goalUserId;
        }

        public CommunicationEntity() { }
    }
}
