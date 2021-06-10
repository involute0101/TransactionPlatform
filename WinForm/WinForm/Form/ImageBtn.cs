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
    public partial class ImageBtn : PictureBox
    {
        private Image normalImage;
        private Image checkedImage;
        public bool stateChange;
        public bool ischecked = false;

        public bool ChangeState
        {
            get { return stateChange; }
            set { stateChange = value; }
        }

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

        public ImageBtn()
        {
            stateChange = false;
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void ImageBtn_MouseEnter(object sender, EventArgs e)
        {
            this.Width += 3;
            this.Height += 3;
        }

        private void ImageBtn_MouseLeave(object sender, EventArgs e)
        {
            this.Width -= 3;
            this.Height -= 3;
        }

        private void ImageBtn_Click(object sender, EventArgs e)
        {
            if(stateChange)
            {
                if(ischecked)
                {
                    ischecked = false;
                    this.Image = normalImage;
                }
                else
                {
                    ischecked = true;
                    this.Image = checkedImage;
                }
            }
        }
    }
}
