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
    public partial class PageRecord : UserControl
    {
        public PageRecord()
        {
            InitializeComponent();
        }

        private void panel2_SizeChanged(object sender, EventArgs e)
        {
            dgvRecord.Height = panel2.Height - 40;
            dgvRecord.Width = panel2.Width - 40;
        }
    }
}
