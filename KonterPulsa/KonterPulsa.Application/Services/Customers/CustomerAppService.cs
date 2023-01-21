using AutoMapper;
using KonterPulsa.Application.Helpers;
using KonterPulsa.Application.Services.Customers.Dto;
using KonterPulsa.Database.Context;
using KonterPulsa.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonterPulsa.Application.Services.Customers
{
	
	public class CustomerAppService : ICustomerAppService
	{
		private readonly TokoContext _context;
		private readonly IMapper _mapper;
		public CustomerAppService(TokoContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public async Task<(bool, Customer)> CreateCustomer(CreateCustomerDto model)
		{
			try
			{
				var customer = _mapper.Map<Customer>(model);
				customer.Id = Guid.NewGuid();
				customer.IsDeleted = false;

				if (customer.Id != null)
				{
					await _context.Database.BeginTransactionAsync();
					await _context.Customers.AddAsync(customer);
					await _context.SaveChangesAsync();
					await _context.Database.CommitTransactionAsync();
				}

				return await Task.Run(()=>( (true, customer)));
			}
			catch (DbException de)
			{
				await _context.Database.RollbackTransactionAsync();
				return await Task.Run(() => (false, new Customer()));
			}						
		}

		public async Task<PageResult<Customer>> GetAll(PageInfo field)
		{
			try
			{
				var result = new PageResult<Customer>()
				{
					Data = (from customer in _context.Customers
							where customer.IsDeleted != true
							select new Customer
							{
								Id = customer.Id,
								Name = customer.Name,
								Address = customer.Address,
							})
							.Skip(field.limit * (field.page - 1))
							.Take(field.limit)
							.OrderBy( w => w.Name),

					Total = _context.Customers.Count()
				};

				return await Task.Run(()=>(result));
			}
			catch(DbException de)
			{
				return await Task.Run(() => (new PageResult<Customer>()));
			}
		}

		public async Task<Customer> GetCustomerByName(string name)
		{
			var customer = _context.Customers.AsNoTracking()
				.Where( w => w.Name == name).FirstOrDefaultAsync(w => w.IsDeleted == false);			

			if (customer == null)
				return await Task.Run(()=>( new Customer()));
			return await Task.Run(() => (customer));
		}

		public async Task<(bool, Customer)> UpdateCustomer(CreateCustomerDto model)
		{
			try
			{
				var customer = new Customer();
				var customerData = await GetCustomerByName(model.Name);
				if(customerData.Name == null)
				{
					return await Task.Run(() => (false, customer));
				}

				var customerUpdate = _mapper.Map<Customer>(model);
				customerUpdate.Id = customerData.Id;
				customerUpdate.IsDeleted = false;

				await _context.Database.BeginTransactionAsync();
				_context.Customers.Update(customerData);
				await _context.SaveChangesAsync();
				await _context.Database.CommitTransactionAsync();

				return await Task.Run(() => (true, customerUpdate));							

			}
			catch (DbException de)
			{
				await _context.Database.RollbackTransactionAsync();
				return await Task.Run(() => (false, new Customer()));
			}
		}
	}
}
