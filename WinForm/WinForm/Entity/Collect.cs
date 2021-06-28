using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForm.Service;

namespace WinForm.EntityClass
{
    class Collect
    {
        public int CollectId { get; set; }

        //postId和userId都是外键
        public int GoodId { get; set; }
        public string GoodName { get; set; }
        public string GoodState { get; set; }
        public int UserId { get; set; }

        public DateTime Time { get; set; }

        public Collect(int goodId, int userId, DateTime time)
        {
            GoodId = goodId;
            UserId = userId;
            Time = time;
            GoodName = GoodService.GetGoodByGoodId(GoodId).GoodName;
            GoodState = GoodService.GetGoodByGoodId(GoodId).State;
        }
    }
}
