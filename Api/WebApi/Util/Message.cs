using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Tool
{
    public class Message
    {
        public int GoodId { get; set; }
        public int SenderId { get; set; }
        public DateTime Time { get; set; }

        public Message(int goodId , int senderId ,DateTime time)
        {
            this.GoodId = goodId;
            this.SenderId = senderId;
            this.Time = time;
        }
    }
}
