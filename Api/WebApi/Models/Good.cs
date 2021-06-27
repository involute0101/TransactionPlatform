using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Good
    {
        public int GoodId { get; set; }
        public int SellerId { get; set; }
        public string SellerName { get; set; }
        public string GoodName { get; set; }
        public byte[] ImageByte { set; get; }
        public Image Image { get; set; }
        public string GoodDetailDesc { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public string State { get; set; }       //商品状态"在售"、"交易中"、"售罄"
    }
}
