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

        public byte[] ImageByte { set; get; }

        public String GoodDetailDesc { get; set; }

        public int Price { get; set; }

        public int count { get; set; }

        public string State { get; set; }       //商品状态"在售"、"交易中"、"售罄"
        public Good() { }
        /*public Good(string GoodName, String Image, string GoodDetailDesc, int Price, int count)
        {
            this.GoodName = GoodName;
            this.Image = Image;
            this.GoodDetailDesc = GoodDetailDesc;
            this.Price = Price;
            this.count = count;
            State = "在售";
        }*/

    }
}
