using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Collect
    {
        public int CollectId { get; set; }
        //postId和userId都是外键
        public int GoodId { get; set; }

        public int UserId { get; set; }

        public DateTime Time { get; set; }

        public Collect(int goodId, int userId, DateTime time)
        {
            GoodId = goodId;
            UserId = userId;
            Time = time;
        }
    }
}
