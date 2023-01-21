using AutoMapper;
using LatihanWebApi.Application.DefaultServices.StudentServices.Dto;
using LatihanWebApi.Database.Databases;
using LatihanWebApi.Database.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanWebApi.Application.DefaultServices.StudentServices
{
    public class StudentAppService : IStudentAppService
    {
        private SchoolContext _schoolContext;
        private IMapper _mapper;
        public StudentAppService(SchoolContext schoolContext, IMapper mapper)
        {
            _schoolContext = schoolContext;
            _mapper = mapper;
        }

        public (bool, string) CreateStudent(CreateStudentDto model)
        {
            try
            {
                var student = _mapper.Map<Students>(model);

                var guid = Guid.NewGuid();
                student.StudentId = guid;

                _schoolContext.Database.BeginTransaction();
                _schoolContext.Students.Add(student);
                _schoolContext.SaveChanges();
                _schoolContext.Database.CommitTransaction();

                return (true, "Succes");
            }
            catch (DbException de)
            {
                _schoolContext.Database.RollbackTransaction();
                return (false, de.Message);


            }
            
        }

        public (bool, string) DeleteStudent(int Id)
        {
            throw new NotImplementedException();
        }

        public (bool, string) UpdateStudent(UpdateStudentDto model)
        {
            throw new NotImplementedException();
        }
    }
}
