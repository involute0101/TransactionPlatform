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
using WebApi.Models;

namespace WinForm
{
    public partial class RegisterForm : Form//注册界面
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        public User newUser;
        private void buttonRegister_Click(object sender, EventArgs e)//生成user对象
        {
            if(!check())return;
            String sex;
            if (radioButtonMale.Checked) sex = radioButtonMale.Text;
            else sex = radioButtonFemale.Text;
            newUser = new User(textBoxUsername.Text, sex,textBoxPhone.Text, textBoxPassword.Text, textBoxEmail.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private bool check()//用户输入信息检测
        {
            //校验密码是否符合
            var regex = new Regex(@"
                (?=.*[0-9])                     #必须包含数字
                .{6,30}                         #至少6个字符，最多30个字符
                ", RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace);                       
            bool pwdIsMatch = regex.IsMatch(textBoxPassword.Text);
            if (!pwdIsMatch) { textBoxPassword.Text = "";MessageBox.Show("错误密码", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);return false;  }
            if (!textBoxPassword.Text.Equals(textBoxSurePassword.Text)) 
            {
                textBoxSurePassword.Text = "";
                MessageBox.Show("前后密码不一致", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            //邮箱正则匹配
            Regex regEmail = new Regex("^[\\w-]+@[\\w-]+\\.(com|net|org|edu|mil|tv|biz|info)$");
            Match m = regEmail.Match(textBoxEmail.Text);
            if (!m.Success) {
                textBoxEmail.Text = "";
                MessageBox.Show("错误邮箱", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            //手机号正则匹配
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxPhone.Text, @"^1[3456789]\d{9}$"))
            {
                textBoxPhone.Text = "";
                MessageBox.Show("错误手机号", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            };
            

            return true;
        }
    }
}
