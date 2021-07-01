using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class TransactionRecord
    {
        public int TransactionRecordId { get; set; }
        //商品id
        public int GoodId { get; set; }
        //商品名称
        public string GoodName { get; set; }
        //买家id
        public int BuyerId { get; set; }
        //卖家id
        public int SalerId { get; set; }
        //销售者名称
        public string SalerName { get; set; }
        //完成交易时间
        public DateTime Time { get; set; }
    }
}
