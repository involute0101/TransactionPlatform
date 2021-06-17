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
using WinForm.Service;

namespace WinForm
{
    public partial class Form_Main : Form
    {
        private bool isSeller = false;
        private bool modifyInfo = false;
        private int pageChoice = 0;
        private PageShop pageShop = new PageShop();
        private PageRecord pageRecord = new PageRecord();
        private PageFavorite pageFavorite = new PageFavorite();
        private PageNews pageNews = new PageNews();
        private Form_Publish publishForm;
        private User user;
        public Form_Main()
        {
            InitializeComponent();

        }
        public Form_Main(string Username)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            user = UserService.GetUser(Username);
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {

            btnChangeInfo.Location = new Point(this.Width - 155, 25);
            shopTable.Height = panel7.Height - 40;
            shopTable.Width = panel7.Width - 40;
            goodsTable.Height = panel7.Height - 40;
            goodsTable.Width = panel7.Width - 40;
            goodsTable.Username = user.Username;
            btnState.Location = new Point(panel1.Width - 100, 2);
            btnLogOut.Location = new Point(panel1.Width - 30, 2);
            btnNews.Location = new Point(panel1.Width - 65, 2);
            //6.10晚修改：显示个人信息
            if (user.ImageByte != null) picHead.Image = Image.FromStream(new MemoryStream(user.ImageByte));
            lblName.InputText = user.Username;
            lblSex.InputText = user.Sex;
            lblPhone.InputText = user.PhoneNumber;
            lblMailBox.InputText = user.Email;
            //picHead.Load(user.Image);             //pictureBox需要Location
            //
            if (isSeller)
            {
                cmbChoice.Text = "预售商品";
            }
            else
            {
                cmbChoice.Text = "商城";
            }
            SwitchTable();
        }

        private void SwitchTable()
        {
            panel7.Controls.Clear();
            if (cmbChoice.Text == "预售商品")
            {
                panel7.Controls.Add(goodsTable);
                goodsTable.bdsGoods.DataSource = GoodService.GetGoodByUserId(user.UserId);
            }
            else
            {
                panel7.Controls.Add(shopTable);
                shopTable.bdsShop.ResetBindings(false);
            }
        }

        private void PageLabelChange()
        {
            switch (pageChoice)
            {
                case 0:
                    {
                        this.btnCenter.ForeColor = System.Drawing.Color.Yellow;
                        this.btnShop.ForeColor = System.Drawing.Color.White;
                        this.btnRecord.ForeColor = System.Drawing.Color.White;
                        this.btnFavorite.ForeColor = System.Drawing.Color.White;
                        this.btnNews.ImageNormal = global::WinForm.Properties.Resources.消_息;
                        break;
                    }
                case 1:
                    {
                        this.btnCenter.ForeColor = System.Drawing.Color.White;
                        this.btnShop.ForeColor = System.Drawing.Color.Yellow;
                        this.btnRecord.ForeColor = System.Drawing.Color.White;
                        this.btnFavorite.ForeColor = System.Drawing.Color.White;
                        this.btnNews.ImageNormal = global::WinForm.Properties.Resources.消_息;
                        break;
                    }
                case 2:
                    {
                        this.btnCenter.ForeColor = System.Drawing.Color.White;
                        this.btnShop.ForeColor = System.Drawing.Color.White;
                        this.btnRecord.ForeColor = System.Drawing.Color.Yellow;
                        this.btnFavorite.ForeColor = System.Drawing.Color.White;
                        this.btnNews.ImageNormal = global::WinForm.Properties.Resources.消_息;
                        break;
                    }
                case 3:
                    {
                        this.btnCenter.ForeColor = System.Drawing.Color.White;
                        this.btnShop.ForeColor = System.Drawing.Color.White;
                        this.btnRecord.ForeColor = System.Drawing.Color.White;
                        this.btnFavorite.ForeColor = System.Drawing.Color.Yellow;
                        this.btnNews.ImageNormal = global::WinForm.Properties.Resources.消_息;
                        break;
                    }
                case 5:
                    {
                        this.btnCenter.ForeColor = System.Drawing.Color.White;
                        this.btnShop.ForeColor = System.Drawing.Color.White;
                        this.btnRecord.ForeColor = System.Drawing.Color.White;
                        this.btnFavorite.ForeColor = System.Drawing.Color.White;
                        this.btnNews.ImageNormal = global::WinForm.Properties.Resources.消_息__选中_; break;
                    }
                default: break;
            }
        }

        private void lblCenter_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            pageCenter.Dock = DockStyle.Fill;
            panel2.Controls.Add(pageCenter);
            pageChoice = 0;
            PageLabelChange();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            pageShop.Dock = DockStyle.Fill;
            panel2.Controls.Add(pageShop);
            pageChoice = 1;
            PageLabelChange();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            pageRecord.Dock = DockStyle.Fill;
            panel2.Controls.Add(pageRecord);
            pageChoice = 2;
            PageLabelChange();


        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            pageFavorite.Dock = DockStyle.Fill;
            panel2.Controls.Add(pageFavorite);
            pageChoice = 3;
            PageLabelChange();
        }

        private void btnNews_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            pageNews.Dock = DockStyle.Fill;
            panel2.Controls.Add(pageNews);
            pageChoice = 4;
            PageLabelChange();
        }

        private void Form_Main_SizeChanged(object sender, EventArgs e)
        {
            shopTable.Height = panel7.Height - 40;
            shopTable.Width = panel7.Width - 40;
            goodsTable.Height = panel7.Height - 40;
            goodsTable.Width = panel7.Width - 40;
            btnLogOut.Location = new Point(panel1.Width - 30, 2);
            btnNews.Location = new Point(panel1.Width - 65, 2);
            btnState.Location = new Point(panel1.Width - 100, 2);
            btnChangeInfo.Location = new Point(this.Width - 155, 25);
        }

        private void btnState_Click(object sender, EventArgs e)
        {
            if (btnState.ischecked)
            {
                cmbChoice.Text = "预售商品";
            }
            else
            {
                cmbChoice.Text = "商城";
            }
            SwitchTable();
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            publishForm = new Form_Publish(user);
            publishForm.ShowDialog();
        }

        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            if (modifyInfo)
            {
                modifyInfo = false;
                lblName.Save();
                lblSex.Save();
                lblPhone.Save();
                lblMailBox.Save();
            }
            else
            {
                modifyInfo = true;
                lblName.Modify();
                lblSex.Modify();
                lblPhone.Modify();
                lblMailBox.Modify();
                //6.11凌晨修改：修改个人信息
                user.Username = lblName.InputText;
                user.Sex = lblSex.InputText;
                user.PhoneNumber = lblPhone.InputText;
                user.Email = lblMailBox.InputText;
                UserService.ModifyUser(user.UserId, user);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }

        private void btnRefrash_Click(object sender, EventArgs e)
        {
            shopTable.bdsShop.DataSource = GoodService.GetAllGoods();
        }

        private void picHead_Click(object sender, EventArgs e)
        {
            //添加上传头像
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "选择要上传的图片";
            ofd.Filter = "All Files(*.*)|*.*|位图(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg";
            ofd.ShowDialog();
            if (!File.Exists(ofd.FileName))
            {
                MessageBox.Show("照片为空");
                return;
            }
            picHead.Load(ofd.FileName);
            user.Image = ofd.FileName;

            FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] imgBytesIn = br.ReadBytes((int)fs.Length);           //将流读入到字节数组中
            user.ImageByte = imgBytesIn;

            UserService.ModifyUser(user.UserId, user);
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            FormControl.form1.Show();
            this.Hide();
        }
    }
}
