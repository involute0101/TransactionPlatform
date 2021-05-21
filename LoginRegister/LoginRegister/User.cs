using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegister
{
    class User
    {
        public int UserId { get; set; }
        public String Username { get; set; }
        public String PhoneNumber { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
        public Image Image { get; set; }

        public User(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
        }
    }
}
