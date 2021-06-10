using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.Service;

namespace WinForm
{
    public partial class ShopTable : UserControl
    {
        public ShopTable()
        {
            InitializeComponent();
            bdsShop.DataSource = GoodService.GetAllGoods();
        }
    }
}
