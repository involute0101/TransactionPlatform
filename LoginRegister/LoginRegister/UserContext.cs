using LoginRegister.EntityClass;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegister
{
    class UserContext:DbContext
    {
        public UserContext() : base("UserDataBase")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<UserContext>());
        }
        public DbSet<User> Users { get; set; }

        public DbSet<Good> Goods { get; set; }

        public DbSet<Collect> Collects { get; set; }

        public DbSet<CommunicationEntity> CommunicationEntities { get; set; }
    }
}
