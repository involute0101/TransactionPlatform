using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegister.EntityClass
{
    class Good
    {
        public int GoodId { get; set; }

        public String GoodName { get; set; }

        public Image GoodImage { get; set; }
        public byte[] imageByte { get; set; }

        public String GoodDetailDesc { get; set; }

        public int Price { get; set; }

        public int count { get; set; }


    }
}
