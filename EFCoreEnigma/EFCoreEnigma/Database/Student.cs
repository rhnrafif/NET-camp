using EFCoreEnigma.Cores;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreEnigma.Database
{
    //model untuk object student
    [Table("Students", Schema = "dbo")] //decorator untuk mendeskripsikan tabel
    public class Student
    {
        [Key] //primarykey
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //aut incree
        [Display(Name ="StudentId")]
        public int StudentId { get; set; }

        [Required] //notnull
        [Column(TypeName ="Nvarchar(20)")]
        [Display(Name = "StudentCode")]
        public string StudentCode { get; set; }

        [Required]
        [Column(TypeName = "Nvarchar(100)")]
        [Display(Name = "StudentName")]
        public string StudentName { get; set; }

        public DateTime? DoB { get; set; }

        [Column(TypeName ="NVarchar(6)")]
        public Gender Gender { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)] //utk generate update terakhir secara computed/dihitung otomatis
        public DateTime LastUpdate { get; set; }
        public virtual StudentAddress StudentAddress { get; set; }

        public virtual ICollection<StudentCourses> StudentCourses { get; set; } //Tabel/Model Student Course
    }
}
