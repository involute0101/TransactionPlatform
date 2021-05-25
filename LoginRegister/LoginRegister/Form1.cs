using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            using (var db = new UserContext())
            {
                User user;
                user = db.Users.SingleOrDefault(u => u.Username.Equals(textBoxUsername.Text)  && u.Password.Equals(textBoxPassword.Text) );
            
                if (user != null) 
                { 
                    Console.WriteLine("登陆成功");
                    //用户界面
                    db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                    DetailForm detailForm = new DetailForm();
                    detailForm.user = user;
                    detailForm.Biding();
                    detailForm.ShowDialog();
                    if (detailForm.DialogResult == DialogResult.OK)//修改更新有效数据
                    {
                        user = detailForm.user;
                        db.SaveChanges();
                    }
                 }
                else
                {
                    Console.WriteLine("登陆失败");
                    MessageBox.Show("登陆失败", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxPassword.Text = "";
                }
             }
            
            

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            
            RegisterForm register = new RegisterForm();
            register.ShowDialog();
            if (register.DialogResult == DialogResult.OK) 
            {
                using (var db = new UserContext())
                {
                    //往数据库中添加新用户
                    db.Users.Add(register.newUser);
                    db.SaveChanges();
                }
            }
        }

        private void buttonForget_Click(object sender, EventArgs e)
        {
            ForgetPassword forget = new ForgetPassword();
            forget.Show();
        }
    }
}
