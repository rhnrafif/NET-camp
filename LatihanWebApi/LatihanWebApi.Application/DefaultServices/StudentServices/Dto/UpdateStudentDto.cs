using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanWebApi.Application.DefaultServices.StudentServices.Dto
{
    public class UpdateStudentDto
    {
        public Guid StudentId { get; set; }
        public string StudentName { get; set; }

        public int Nisn { get; set; }

        public string Address { get; set; }

        public string? Parent { get; set; }
    }
}
