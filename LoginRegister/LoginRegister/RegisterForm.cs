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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        public User newUser;
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if(!check())return;
            newUser = new User(textBoxUsername.Text, textBoxPassword.Text, textBoxEmail.Text, textBoxPhone.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private bool check()
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
