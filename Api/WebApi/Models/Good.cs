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
        //销售者id
        public int SellerId { get; set; }
        //销售者名称
        public string SellerName { get; set; }
        //商品名称
        public string GoodName { get; set; }
        //商品图片的字节数组
        public byte[] ImageByte { set; get; }
        //商品详情
        public string GoodDetailDesc { get; set; }
        //价格
        public int Price { get; set; }
        //数量
        public int Count { get; set; }
        //商品状态
        public string State { get; set; }       //商品状态"在售"、"交易中"、"售罄"
    }
}
