using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreEnigma.Database
{
    [Table("Courses", Schema ="dbo")]
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Course Id")]
        public int CourseId { get; set; }

        [Required]
        [Column(TypeName ="Nvarchar(200)")]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        public int TeacherId { get; set; } //FK dari model/tabel Teacher
        public virtual Teacher Teachers { get; set; }  //implementasi dari model Teachers
        public virtual ICollection<StudentCourses> StudentCourses { get; set; } //Tabel StudnetCourse

    }
}
