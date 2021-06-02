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
    public partial class RoundBtn : PictureBox
    {
        public RoundBtn()
        {
            InitializeComponent();
        }

        private Image normalImage;
        private Image checkedImage;
        private bool check = false;

        public Image ImageNormal
        {
            get { return normalImage; }
            set { normalImage = value; }
        }

        public Image ImageChecked
        {
            get { return checkedImage; }
            set { checkedImage = value; }
        }

        private void RoundBtn_MouseEnter(object sender, EventArgs e)
        {
            this.Width += 5;
            this.Height += 5;
            if (!check)
            {
                this.Image = normalImage;
            }
        }

        private void RoundBtn_MouseLeave(object sender, EventArgs e)
        {
            this.Width -= 5;
            this.Height -= 5;
            if (!check)
                {
                this.Image = normalImage;
                 }
        }

        public void RoundBtn_Click(object sender, EventArgs e)
        {
            check = true;
            this.Image = checkedImage;
        }

        public void Unchecked()
        {
            check = false;
            this.Image = normalImage;
        }
        /*protected override void OnPaint(PaintEventArgs pe)
{
base.OnPaint(pe);
}*/
    }
}
