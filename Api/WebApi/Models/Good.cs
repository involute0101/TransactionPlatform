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

        public String GoodName { get; set; }

        public byte[] ImageByte { get; set; }

        public String GoodDetailDesc { get; set; }

        public int Price { get; set; }

        public int count { get; set; }

        public string State { get; set; }       //商品状态"在售"、"交易中"、"售罄"
    }
}
