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
        //买家id
        public int UserId { get; set; }

        public int SellerId { get; set; }

        //聊天信息
        public string CommentRecords { get; set; }

        public DateTime Time { get; set; }

        public Comment()
        {
        }
    }
}
