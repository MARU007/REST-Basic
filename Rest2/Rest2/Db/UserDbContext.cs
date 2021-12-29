using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rest2.Models;

namespace Rest2.Db
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options)
        {
        }
        public UserDbContext() { }
        public DbSet<User> Users { get; set; }
       public DbSet<Address> Address { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("server = DESKTOP-4DPMTTM; database = MyDb; Trusted_Connection = True;");
        }
    }
}
