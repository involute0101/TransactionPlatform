using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegister.EntityClass
{
    public class CommunicationEntity
    {
        public int CommunicationEntityId { get; set; }

        public String ipStringPort { get; set; }

        public String UserId { get; set; }          //操作中转换为int

        public CommunicationEntity(String ipStringPort, String UserId)
        {
            this.ipStringPort = ipStringPort;
            this.UserId = UserId;
        }

        public CommunicationEntity() { }
    }
}
