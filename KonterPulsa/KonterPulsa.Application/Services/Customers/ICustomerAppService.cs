using KonterPulsa.Application.Helpers;
using KonterPulsa.Application.Services.Customers.Dto;
using KonterPulsa.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonterPulsa.Application.Services.Customers
{
	public interface ICustomerAppService
	{
		Task<(bool, Customer)> CreateCustomer(CreateCustomerDto model);
		Task<(bool, Customer)> UpdateCustomer(CreateCustomerDto model);
		Task<Customer> GetCustomerByName(string name);
		Task<PageResult<Customer>> GetAll(PageInfo field);
	}
}
