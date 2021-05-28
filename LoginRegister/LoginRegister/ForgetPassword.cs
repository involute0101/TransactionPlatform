using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegister
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void buttonRetrieve_Click(object sender, EventArgs e)//用户信息匹配则用邮箱发送密码
        {
            User user;
            /*using (var db = new UserContext())
            {
                user = db.Users.SingleOrDefault(u => u.Username.Equals(textBoxUsername.Text)  && u.PhoneNumber.Equals(textBoxPhone.Text));
            }*/
            user = UserService.GetUser(textBoxUsername.Text, textBoxPhone.Text);

            if (user == null) {  
                MessageBox.Show("查找用户失败", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //成功查找到用户，向其注册邮箱发送密码
            //wkklavis@163.com向用户邮箱发送验证邮件
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("wkklavis@163.com");
            mailMessage.To.Add(user.Email);
            mailMessage.Subject = "验证邮件";
            mailMessage.Body = "您的密码是："+user.Password;
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Credentials = new System.Net.NetworkCredential("wkklavis@163.com", "TUMQJCXFBKNACYUG");
            smtpClient.Host = "smtp.163.com";
            smtpClient.Send(mailMessage);
            Console.WriteLine(user.Password);


        }
    }
}
