using SOLIDExample.Application.SeedWorks;
using SOLIDExample.Application.Services.BasketServices;
using SOLIDExample.Application.Services.InvoiceServices;
using SOLIDExample.Application.Services.OrderServices.Dto;
using SOLIDExample.Entity.Orders;
using SOLIDExample.Infrastructure.SeedWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExample.Application.Services.OrderServices
{
    public class OrderAppService : BaseService, IOrderAppService
    {
        private readonly IBasketAppService _basketAppService;
        private readonly IInvoiceAppService _invoiceAppService;

        private readonly IRepository<Order> _orderRepo;
        public OrderAppService(IUnitOfWorks unitOfWork, 
            IBasketAppService basketAppService, 
            IInvoiceAppService invoiceAppService, 
            IRepository<Order> orderRepo) : base(unitOfWork)
        {
            _orderRepo = orderRepo;
            _basketAppService = basketAppService;
            _invoiceAppService = invoiceAppService;
        }

        public async Task<Order> CreateOrder(OrderInfoDto orderInfo)
        {
            var order = new Order(orderInfo.Type, orderInfo.CustomerName, orderInfo.Address);
            var basket = await _basketAppService.Get(orderInfo.BasketId);
            foreach(var item in basket.Products)
            {
                order.AddProductItem(item.Product, item.Quantity);
            }

            await UnitOfWork.ExecuteTransactionAsync(async () =>
            {
                _orderRepo.Add(order);
                await _basketAppService.MarkAsResolved(orderInfo.BasketId);
                return await UnitOfWork.SaveChangesAsync();
            });

            return order;
        }

        public async Task<Order> GetById(int id)
        {
            return await _orderRepo.GetAsync(id);
        }

        public async Task MarkOrderAsPaid(int orderId)
        {
            var order = await _orderRepo.GetAsync(orderId);
            order.Status = Entity.OrderStatus.Paid;
            await UnitOfWork.ExecuteTransactionAsync(async () =>
            {
                order.InvoiceId = await _invoiceAppService.CreateInvoice(order);
                return await UnitOfWork.SaveChangesAsync();
            });
        }
    }
}
