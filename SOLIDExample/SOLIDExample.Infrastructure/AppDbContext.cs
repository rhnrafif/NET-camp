using Microsoft.EntityFrameworkCore;
using SOLIDExample.Entity.SeedWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExample.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries()
                .Where( e => e.Entity is EntityBase && (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((EntityBase)entityEntry.Entity).UpdateDate= DateTime.Now;

                if( entityEntry.State == EntityState.Added)
                {
                    ((EntityBase)entityEntry.Entity).CreateDate = DateTime.Now;
                }

            }
            return base.SaveChanges();
        }
    }
}
