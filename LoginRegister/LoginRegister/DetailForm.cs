using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegister
{
    public partial class DetailForm : Form
    {
        public User user;
        public DetailForm()
        {
            InitializeComponent();

            /*GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(pictureBox1.ClientRectangle);
            Region region = new Region(gp);
            pictureBox1.Region = region;
            gp.Dispose();
            region.Dispose();*/

        }

        public void Biding()//用户数据显示
        {
            textBoxName.Text = user.Username;
            if (user.Sex.Equals("男")) { radioButtonMale.Checked = true;radioButtonFemale.Checked = false; }
            else { radioButtonMale.Checked = false;radioButtonFemale.Checked = true; }
            textBoxEmail.Text = user.Email;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
            pictureBoxHead.Load(ofd.FileName);

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //头像框绘制边框
            PictureBox p = (PictureBox)sender;
            Pen pp = new Pen(Color.Gray);
            e.Graphics.DrawRectangle(pp, e.ClipRectangle.X, e.ClipRectangle.Y,
                e.ClipRectangle.X + e.ClipRectangle.Width - 1,
                e.ClipRectangle.Y + e.ClipRectangle.Height - 1);
        }

        private void buttonSave_Click(object sender, EventArgs e)//个人邮箱数据修改后正则匹配
        {
            user.Username = textBoxName.Text;
            user.Email = textBoxEmail.Text;
            if (radioButtonMale.Checked) user.Sex = "男";
            else user.Sex = "女";
            

            Regex regEmail = new Regex("^[\\w-]+@[\\w-]+\\.(com|net|org|edu|mil|tv|biz|info)$");
            Match m = regEmail.Match(textBoxEmail.Text);
            if (!m.Success)
            {
                textBoxEmail.Text = "";
                MessageBox.Show("错误邮箱", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
