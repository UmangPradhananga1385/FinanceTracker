using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PersonalMoneyTracker.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalMoneyTracker.Data
{
    public  class PersonalMoneyTracketDbContext : DbContext
    {
        
        public PersonalMoneyTracketDbContext()
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<DebtDetails> DebtDetails { get; set; }
        public DbSet<Tags> Labels { get; set; }
        public DbSet<Transaction> Transactions { get; set; }    
        public DbSet<Balance> Balances { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=pg-221de78f-umangpradhananga1385-2b73.j.aivencloud.com;Port=20347;Database=defaultdb;Username=avnadmin;Password=AVNS_-ox5cqgciOHaWmiXloo;SslMode=Require");
        }
    }
}
