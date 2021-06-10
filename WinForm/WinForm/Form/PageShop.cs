using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class PageShop : UserControl
    {
        public PageShop()
        {
            InitializeComponent();
        }

        private void panel2_SizeChanged(object sender, EventArgs e)
        {
            shopTable.Height = panel2.Height - 40;
            shopTable.Width = panel2.Width - 40;
        }
    }
}
