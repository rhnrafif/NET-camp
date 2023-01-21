using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanEF.Database
{
    public class ShopContext :DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=RHNRAFIF\SQLEXPRESS;Database=ShopDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
