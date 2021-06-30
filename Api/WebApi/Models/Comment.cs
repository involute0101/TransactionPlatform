using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Comment
    {
        public int CommentId { get; set; }

        //商品
        public int GoodId { get; set; }
        //发送者id
        public int SenderId { get; set; }
        //接受者id
        public int ReceiverId { get; set; }
        //聊天信息类型
        public String InfoType { get; set; }
        //文字信息
        public string WordRecords { get; set; }
        //图片信息
        public byte[] ImageByte { set; get; }
        //经度
        public string longitude { get; set; }
        //纬度
        public string latitude { get; set; }

        public DateTime Time { get; set; }

        public Comment()
        {
        }
    }
}
