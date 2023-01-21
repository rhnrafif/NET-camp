using SOLIDExample.Application.Services.OrderServices.Dto;
using SOLIDExample.Entity.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExample.Application.Services.OrderServices
{
    public interface IOrderAppService
    {
        Task<Order> GetById(int id);
        Task<Order> CreateOrder(OrderInfoDto orderInfo);
        Task MarkOrderAsPaid(int orderId);
    }
}
