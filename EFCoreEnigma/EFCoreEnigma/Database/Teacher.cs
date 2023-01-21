using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreEnigma.Database
{
    [Table("Teachers",Schema = "dbo")]
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Teacher Id")]
        [Required]
        public int TeacherId { get; set; }

        [Required]
        [Column(TypeName ="NVarchar(100)")]
        [Display(Name ="Fisrt Name")]
        public string FirstName { get; set; }

        [Column(TypeName ="Nvarchar(100)")]
        [Display(Name ="Last Name")]
        public string? LastName { get; set; }

        public virtual ICollection<Course> Courses { get; set; } 
        //ICollection sebagai penanda bahwa teacher bisa berelasi dengan banyak course. sehingga ditampung ke collection
        //yang berperan sebagai One adalah tecaher dan Many adalah Course
        //'Satu guru bisa mengajar banyak Course'

    }
}
