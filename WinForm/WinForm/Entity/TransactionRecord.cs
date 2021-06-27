using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WinForm.Service;

namespace WinForm.EntityClass
{
    public class TransactionRecord
    {
        public int TransactionRecordId { get; set; }

        public int GoodId { get; set; }//商品
        public string GoodName { get; set; }
        public int BuyerId { get; set; }//买家
        public int SalerId { get; set; }//卖家
        public string SalerName { get; set; }
        public DateTime Time { get; set; }//完成交易时间

        public TransactionRecord(int goodId, int buyerId, int salerId, DateTime time)
        {
            GoodId = goodId;
            BuyerId = buyerId;
            SalerId = salerId;
            Time = time;
            GoodName = GoodService.GetGoodByGoodId(GoodId).GoodName;
            SalerName = UserService.GetUserByUserId(salerId).Username;
        }
    }
}
