using KonterPulsa.Application.Helpers;
using KonterPulsa.Application.Services.Customers;
using KonterPulsa.Application.Services.Customers.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.Common;

namespace KonterPulsa.Controllers
{
	[Route("api/customers/")]
	[ApiController]
	public class CustomerController : ControllerBase
	{
		private readonly ICustomerAppService _customerAppService;
		public CustomerController(ICustomerAppService customerAppService)
		{
			_customerAppService = customerAppService;
		}

		[HttpPost("create")]
		[AllowAnonymous]
		public async Task<IActionResult> CreateCustomer([FromBody] CreateCustomerDto model)
		{
			try
			{
				if(model.Name != null && model.Address != null)
				{
					var (isCreated, data) = await _customerAppService.CreateCustomer(model);
					if (isCreated)
					{
						return await Task.Run(() => (Requests.Response(this, 200, 
							new CreateCustomerDto() { Name = data.Name, Address = data.Address}, "Success")));
					}
					return await Task.Run(() => (Requests.Response(this, 502, data, "Error")));
				}
				return await Task.Run(() => (Requests.Response(this,400, null, "Bad Request")));
			}
			catch(DbException de)
			{
				return await Task.Run(() => (Requests.Response(this, 500, null, "Error")));
			}
		}

		[HttpGet("allcustomer")]
		[AllowAnonymous]
		public async Task<IActionResult> GetAllCustomer([FromQuery] PageInfo field)
		{
			try
			{
				var dataCustomer = await _customerAppService.GetAll(field);
				if(dataCustomer.Total != 0)
				{
					return await Task.Run(() => (Requests.Response(this, 200, dataCustomer, "success")));
				}
				return await Task.Run(() => (Requests.Response(this, 404, null, "Not Found")));
			}
			catch(DbException de)
			{
				return await Task.Run(() => (Requests.Response(this, 500, null, de.Message)));
			}
		}
	}
}
