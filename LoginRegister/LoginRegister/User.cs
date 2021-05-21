using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegister
{
   public class User
    {
        public int UserId { get; set; }
        public String Username { get; set; }
        public String PhoneNumber { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
        public string Image { get; set; }

        public User(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
        }

        public User()
        {
        }

        public User(string username,string password, string email,string phoneNumber) : this(username, password, email)
        {
            PhoneNumber = phoneNumber;
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
