using AutoMapper;
using KonterPulsa.Application.Services.Customers.Dto;
using KonterPulsa.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonterPulsa.Application.ConfigProfile
{
	public class ConfigurationProfile : Profile
	{
		public ConfigurationProfile()
		{
			CreateMap<Customer, CreateCustomerDto>();
			CreateMap<CreateCustomerDto, Customer>();
		}
	}
}
