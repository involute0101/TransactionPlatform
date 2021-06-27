using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForm.Service;

namespace WinForm.EntityClass
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
        public Good() { }
        public Good(string GoodName, byte[] imageBytes, string GoodDetailDesc, int Price, int count)
        {
            this.GoodName = GoodName;
            ImageByte = imageBytes;
            this.GoodDetailDesc = GoodDetailDesc;
            this.Price = Price;
            Count = count;
            SellerName = UserService.GetUserByUserId(SellerId).Username;
            State = "在售";
        }
    }
}
