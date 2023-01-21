
namespace LatihanWebApi.Application.DefaultServices.StudentServices.Dto
{
    public class CreateStudentDto
    {
        public string StudentName { get; set; }

        public int Nisn { get; set; }

        public string Address { get; set; }

        public string? Parent { get; set; }
    }
}
