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
        
        public int UserId { set; get; }//用户Id，外键，所属的用户

        public String GoodName { get; set; }

        public Image GoodImage { get;  }
        public byte[] imageByte { get; set; }

        public String GoodDetailDesc { get; set; }

        public int Price { get; set; }

        public int Count { get; set; }

        public string State { get; set; }//商品状态"在售"、"交易中"、"售罄"
    }
}
