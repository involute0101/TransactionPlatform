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
    public partial class SubPageCenter : UserControl
    {
        public SubPageCenter()
        {
            InitializeComponent();
        }

        private void lblRecord_Click(object sender, EventArgs e)
        {
            Form form = new FormRecord();//参数
            form.ShowDialog();
        }

        private void lblfavorite_Click(object sender, EventArgs e)
        {
            Form form = new FormFavorite();//参数
            form.ShowDialog();
        }

        private void lblChangeInfo_Click(object sender, EventArgs e)
        {
            Form form = new FormInformation();//参数
            form.ShowDialog();
        }
    }
}
