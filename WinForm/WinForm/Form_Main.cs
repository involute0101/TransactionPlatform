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
    public partial class Form_Main : System.Windows.Forms.Form
    {
        public SubpageShop page_shop = new SubpageShop();
        public SubPageCenter page_center = new SubPageCenter();
        public SubPagePublish page_publish = new SubPagePublish();

        public Form_Main()
        {
            InitializeComponent();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            page_shop.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(page_shop);
            btnPublish.Unchecked();
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            page_publish.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(page_publish);
        }


        private void btnCenter_Click(object sender, EventArgs e)
        {
            page_center.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(page_center);
            btnPublish.Unchecked();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            panel2.Height = this.Height - 77;
        }


        private void Form_Main_Load(object sender, EventArgs e)
        {
            panel2.Height = this.Height - 77;
            panel2.Controls.Add(page_shop);
            btnPublish.BringToFront();
        }

    }


    //临时
    public class User
    {
        public User()
        {
            this.name = "测试1";
            this.sex = "男"; 
            this.phone = "1234567890"; 
            this.mailBox = "test1234@163.com";
        }
        public string name { get; set; }
        public string sex { get; set; }
        public string phone { get; set; }
        public string mailBox { get; set; }
    }
}





