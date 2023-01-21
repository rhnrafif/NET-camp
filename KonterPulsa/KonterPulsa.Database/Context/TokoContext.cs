using KonterPulsa.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonterPulsa.Database.Context
{
	public class TokoContext : DbContext
	{
		public DbSet<Auth> Auths { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Transaction> Transactions { get; set; }
		public TokoContext(DbContextOptions<TokoContext> options) : base(options) { }
	}
}
