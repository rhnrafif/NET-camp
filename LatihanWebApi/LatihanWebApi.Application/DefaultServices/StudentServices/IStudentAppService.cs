using LatihanWebApi.Application.DefaultServices.StudentServices.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanWebApi.Application.DefaultServices.StudentServices
{
    public interface IStudentAppService
    {
        (bool, string) CreateStudent(CreateStudentDto model);
        (bool, string) UpdateStudent(UpdateStudentDto model);
        (bool, string) DeleteStudent(int Id);
    }
}
