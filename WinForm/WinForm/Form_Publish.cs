
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebApi.Models;
using WinForm.EntityClass;
using WinForm.Service;
using WinForm;

namespace WinForm
{
    //修改
    public partial class Form_Publish : Form
    {
        Good good = new Good();
        User user;
        public Form_Publish()
        {
            InitializeComponent();
        }
        public Form_Publish(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "选择要上传的图片";
            ofd.Filter = "All Files(*.*)|*.*|位图(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg";
            ofd.ShowDialog();
            if (!File.Exists(ofd.FileName))
            {
                MessageBox.Show("照片为空");
                return;
            }
            good.Image.Add(ofd.FileName);
        }

        private void btnAddGood_Click(object sender, EventArgs e)
        {
            if (txtGoodName.Text != null)
                good.GoodName = txtGoodName.Text;
            if (txtGoodNumber.Text != null)
                good.count = int.Parse(txtGoodNumber.Text);
            if (txtGoodPrice.Text != null)
                good.Price = int.Parse(txtGoodPrice.Text);
            if (textBox1.Text != null)
                good.GoodDetailDesc = textBox1.Text;
            good.State = "在售";
            good.SellerId = user.UserId;
            GoodService.AddPost(good);
        }
    }
}
