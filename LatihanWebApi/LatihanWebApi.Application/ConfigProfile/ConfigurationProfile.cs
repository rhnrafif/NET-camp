using AutoMapper;
using LatihanWebApi.Application.DefaultServices.StudentServices.Dto;
using LatihanWebApi.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanWebApi.Application.ConfigProfile
{
    public class ConfigurationProfile : Profile
    {
        public ConfigurationProfile()
        {
            CreateMap<Students, CreateStudentDto>();
            CreateMap<CreateStudentDto, Students>();
        }
    }
}
