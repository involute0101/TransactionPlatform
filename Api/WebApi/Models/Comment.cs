using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Comment
    {
        public int CommentId { get; set; }

        //聊天记录,选定商品ID，与哪一个买家UserID，里面有CommentRecords
        public int GoodId { get; set; }

        public int UserId { get; set; }

        public string UserName { get; set; }

        public string CommentRecords { get; set; }

        public DateTime Time { get; set; }

        public Comment()
        {
        }
    }
}
