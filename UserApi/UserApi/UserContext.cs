using LoginRegister;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserApi
{
    public class UserContext : DbContext
    {
        public UserContext (DbContextOptions<UserContext> options)
           : base(options)
        {
            this.Database.EnsureCreated(); //自动建库建表
        }

        public DbSet<User> Users { get; set; }
    }
}
