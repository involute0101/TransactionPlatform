using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebApi.Models;
using WinForm;
using WinForm.Service;
using WinForm.Tool;

namespace WinForm
{
    public partial class Form1 : Form//登陆界面
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            UserService.client = client;
            TransactionService.client = client;
            GoodService.client = client;
            CommentService.client = client;
            CollectService.client = client;
            //用户登录主界面
            var token = await UserService.LoginUser(textBoxUsername.Text, textBoxPassword.Text);

            User user = UserService.GetUser(textBoxUsername.Text);
            //个人信息主页部分

            if (user != null)
            {
                Console.WriteLine("登陆成功");
                
                StaticVar.USERID = "" + user.UserId;
                Form_Main form_Main = new Form_Main(user.Username);
               
                this.Hide();
                form_Main.Show();
            }
            else
            {
                Console.WriteLine("登陆失败");
                MessageBox.Show("登陆失败", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxPassword.Text = "";
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {

            RegisterForm register = new RegisterForm();
            register.ShowDialog();
            if (register.DialogResult == DialogResult.OK)
            {
                UserService.RegisterUser(register.newUser);
            }
        }

        private void buttonForget_Click(object sender, EventArgs e)
        {
            ForgetPassword forget = new ForgetPassword();
            forget.Show();
        }
    }
}
