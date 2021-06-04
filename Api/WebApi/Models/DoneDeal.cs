using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class DoneDeal//成功交易
    {
        public int DoneDealId { get; set; }

        public int GoodId { get; set; }//商品+卖家

        public int UserId { get; set; }//买家

        public DateTime Time { get; set; }//完成交易时间

        public DoneDeal()
        {
        }
    }
}
