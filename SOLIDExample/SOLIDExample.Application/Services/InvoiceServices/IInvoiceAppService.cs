using SOLIDExample.Entity.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExample.Application.Services.InvoiceServices
{
    public interface IInvoiceAppService
    {
        Task<int> CreateInvoice(Order order);
        Task Sign(int orderId);
        Task<string> Export(int orderId);
    }
}
