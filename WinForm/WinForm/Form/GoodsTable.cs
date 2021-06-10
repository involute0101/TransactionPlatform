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
using WinForm.Tool;

namespace WinForm
{
    public partial class GoodsTable : UserControl
    {
        public string Username;
        public GoodsTable()
        {
            InitializeComponent();
            bdsGoods.DataSource = GoodService.GetGoodByUserId(Int32.Parse(StaticVar.USERID));
        }
    }
}
