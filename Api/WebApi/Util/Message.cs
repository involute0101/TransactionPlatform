using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Tool
{
    public class Message
    {
        //商品名称
        public string GoodName { get; set; }
        //商品id
        public int GoodId { get; set; }
        //发送者id
        public int SenderId { get; set; }
        //信息时间
        public DateTime Time { get; set; }

        public Message(string goodName,int goodId , int senderId ,DateTime time)
        {
            this.GoodName = goodName;
            this.GoodId = goodId;
            this.SenderId = senderId;
            this.Time = time;
        }
    }
}
