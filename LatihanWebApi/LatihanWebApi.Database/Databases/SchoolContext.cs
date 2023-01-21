using LatihanWebApi.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanWebApi.Database.Databases
{
    public class SchoolContext : DbContext
    {
        public DbSet<Students> Students { get; set; }
        public SchoolContext(DbContextOptions<SchoolContext> dbContextOptions) : base(dbContextOptions)
        {

        }

    }
}
