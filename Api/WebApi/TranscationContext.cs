using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;


namespace WebApi
{
    public class TranscationContext : DbContext
    {
        public TranscationContext(DbContextOptions<TranscationContext> options)
           : base(options)
        {
            this.Database.EnsureCreated(); //自动建库建表
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Good> Goods { get; set; }

        public DbSet<Collect> Collects { get; set; }

        public DbSet<CommunicationEntity> CommunicationEntities { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<TransactionRecord> TransactionRecords { get; set; }
    }
}
