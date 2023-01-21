using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace AutoMapperEnigma.ConfigProfile
{
    public class ConfigurationProfile : Profile //Profile berasal dari libary AutoMapper
    {
        public ConfigurationProfile()
        {
            CreateMap<Employee, EmployeeDto>(); //model dan DTO yang sudah di create sebelumnya
            CreateMap<EmployeeDto, Employee>(); //insert dari Dto ke Employee

            //Configurasi untuk field yang namanya berbeda ada di SS
        }
    }
}
