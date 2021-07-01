using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class User
    {
        public int UserId { get; set; }
        //用户名
        public String Username { get; set; }
        //性别
        public String Sex { get; set; }
        //电话号码
        public String PhoneNumber { get; set; }
        //密码
        public String Password { get; set; }
        //邮箱
        public String Email { get; set; }
        //头像图片的字节数组
        public byte[] ImageByte { set; get; }
        
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
