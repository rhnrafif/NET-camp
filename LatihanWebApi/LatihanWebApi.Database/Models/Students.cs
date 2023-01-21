using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanWebApi.Database.Models
{
    [Table("Student", Schema = "dbo")]
    public class Students
    {
        [Key]
        [Column("student_id")]
        [Display(Name = "Student Id")]
        public Guid StudentId { get; set; }

        [Column("student_name", TypeName = "NVarchar(50)")]
        [Display(Name = "Student Name")]
        [Required]
        public string StudentName { get; set; }

        [Column("nisn")]
        [Display(Name = "NISN")]
        [Required]
        public int Nisn { get; set; }

        [Column("address")]
        [Display(Name = "address")]
        [Required]
        public string Address { get; set; }

        [Column("parent")]
        [Display(Name = "parent")]
        public string? Parent { get; set; }

    }
}
