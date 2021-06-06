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
    public partial class PageFavorite : UserControl
    {
        public PageFavorite()
        {
            InitializeComponent();
        }

        private void panel2_SizeChanged(object sender, EventArgs e)
        {
            goodsTable.Height = panel2.Height - 40;
            goodsTable.Width = panel2.Width - 40;
        }
    }
}
