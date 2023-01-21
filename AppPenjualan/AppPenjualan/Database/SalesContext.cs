using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AppPenjualan.Database
{

    public class SalesContext : DbContext
    {
        public DbSet<Products> Products { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Transactionns> Transactionns { get; set; }
        public DbSet<TransactionDetails> TransactionDetails { get; set; }

        public SalesContext(DbContextOptions<SalesContext> option) : base(option)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    var connStr = "Server=RHNRAFIF\\SQLEXPRESS;Database=Sales;Trusted_Connection=True;TrustServerCertificate=True;";
        //    optionsBuilder.UseSqlServer(connStr);
        //}
    }
}
