using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreEnigma.Database
{
    [Table("StudentCourses", Schema = "dbo")]
    public class StudentCourses
    {
        //Table Student Course sebagai conjuction table antara Model Student dengan Model Courses
        public int StudentId { get; set; }
        public virtual Student Students { get; set; } //implementasi dari model Student
        public int CourseId { get; set; }
        public virtual Course Courses { get; set; } //implementasi dari model Course
    }
}
