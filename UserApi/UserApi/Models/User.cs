using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegister
{
   public class User
    {
        public int UserId { get; set; }
        public String Username { get; set; }//用户名
        public String Sex { get; set; }//性别
        public String PhoneNumber { get; set; }//电话号码
        public String Password { get; set; }//密码
        public String Email { get; set; }//邮箱
        public string Image { get; set; }//存放地址用来访问服务器端图片

        public User(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
        }

        public User()
        {
        }

        public User(string username, string sex, string phoneNumber, string password, string email) 
        {
            Username = username;
            Sex = sex;
            PhoneNumber = phoneNumber;
            Password = password;
            Email = email;
        }

        public User(int userId, string username, string phoneNumber, string password, string email)
        {
            UserId = userId;
            Username = username;
            PhoneNumber = phoneNumber;
            Password = password;
            Email = email;
            
        }
    }
}
