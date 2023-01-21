using EFCoreEnigma.Cores;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreEnigma.Database
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
        public DbSet<Teacher> Teachers { get; set;}
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourses> StudentCourses { get; set; }
        public DbSet<Parents> Parents { get; set; }
        public DbSet<vw_StudentAddress> vw_StudentAddresses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //get connection string from appsettings.json
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional : false);
            var configuration = builder.Build();

            string connStr = configuration.GetConnectionString("DBConnection");

            optionsBuilder.UseSqlServer(connStr);
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourses>().HasKey(sc => new { sc.StudentId, sc.CourseId });
            //disesuaikan dengan model table conjuctionnnya

            modelBuilder.Entity<Teacher>().HasData( 
                //Dataseed, untuk insert pertama ketika deploy database //data default misalnya
                //Data dibuat tanpa menggunakan service berbeda
                new {TeacherId = 1, FirstName = "Raihanudin", LastName = "Rafif"},
                new {TeacherId = 2, FirstName = "Malik", LastName = "Reza"},
                new {TeacherId = 3, FirstName = "Terry", LastName = "Jhon"});

            modelBuilder.Entity<Parents>().Property(p => p.ParentId).HasDefaultValueSql("NEWID()"); //untuk membuat GUID

            modelBuilder.Entity<Parents>().HasData(
                new Parents() { ParentId = Guid.NewGuid(), ParentName = "Minato", Address = "Konoha"},
                new Parents() { ParentId = Guid.NewGuid(), ParentName = "Hizashi", Address = "Konoha"}
                );

            modelBuilder.Entity<vw_StudentAddress>(
                vsa => { 
                    vsa.HasNoKey();
                    vsa.ToView("View_StudentAddress"); //ini disesuaikan dengan query yang telah dieksekusi di SQL Server / SSMS
                
                });

            modelBuilder.Entity<Student>().Property(lu => lu.LastUpdate).ValueGeneratedOnAddOrUpdate();
            //untuk implementsasi last update di model student
            modelBuilder.Entity<Student>().Property(lu => lu.LastUpdate).HasDefaultValueSql("GetDate()"); //fungsi utk generate date dr SQL Syntax

            modelBuilder.Entity<Student>().Property(g => g.Gender) //mengonversi ketika ditampilkan di aplikasi menjadi male dan female
                .HasConversion(
                    eg => eg.ToString(),
                    eg => (Gender)Enum.Parse(typeof(Gender), eg)
                ) ;
        }
    }
}
