using SOLIDExample.Application.SeedWorks;
using SOLIDExample.Application.Services.OrderServices;
using SOLIDExample.Entity;
using SOLIDExample.Entity.Entities.Invoices;
using SOLIDExample.Entity.Orders;
using SOLIDExample.Infrastructure.SeedWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExample.Application.Services.InvoiceServices
{
    public class InvoiceAppService : BaseService, IInvoiceAppService
    {
        //private readonly IRepository<Order> _order; //violating SOLID Principle
        private readonly IOrderAppService _orderAppService;
        private readonly IRepository<CompanyInvoice> _companyInvoiceRepo;
        private readonly IRepository<PersonalInvoice> _personalInvoiceRepo;
        public InvoiceAppService(IUnitOfWorks unitOfWork,
            IRepository<CompanyInvoice> companyInvoiceRepo,
            IOrderAppService orderAppService,
            IRepository<PersonalInvoice> personalInvoiceRepo, 
            IRepository<Order> order) : base(unitOfWork)
        {
            _companyInvoiceRepo = companyInvoiceRepo;
            _orderAppService = orderAppService;
            _personalInvoiceRepo = personalInvoiceRepo;
            //_order = order; //violating SOLID priciple
        }

        public async Task<int> CreateInvoice(Order order)
        {
            InvoiceBase invoice;
            switch (order.Type)
            {
                case Entity.OrderType.Company:
                    invoice = new CompanyInvoice(order, 111);
                    _companyInvoiceRepo.Add((CompanyInvoice)invoice);
                    break;
                case Entity.OrderType.Personal:
                    invoice = new PersonalInvoice(order);
                    _personalInvoiceRepo.Add((PersonalInvoice)invoice);
                    break;
                default:
                    throw new Exception("OrderType not Exits");
                    break;
            }

            await UnitOfWork.SaveChangesAsync();
            return invoice.Id;
        }

        public async Task<string> Export(int orderId)
        {
            var order = await _orderAppService.GetById(orderId);
            var invoiceId = order.InvoiceId.GetValueOrDefault();
            var invoice = await GetInvoiceByType(order, invoiceId);

            return invoice?.Export();
        }

        public async Task Sign(int orderId)
        {
            var order = await _orderAppService.GetById(orderId);
            var invoiceId = order.InvoiceId.GetValueOrDefault();
            var invoice = await GetInvoiceByType(order, invoiceId);
            
            invoice?.Sign();
        }

        ////wrong example
        //public async Task Sign (int orderId)
        //{
        //    var order = await _orderAppService.GetById(orderId);
        //    var invoiceId = order.InvoiceId.GetValueOrdefault();
        //    var invoice = await GetInvoiceByType(order, invoiceId);

        //    switch (order.Type)
        //    {
        //        case OrderType.Company:
        //            //sign company invoice
        //            break;
        //        case OrderType.Personal:
        //            //sign personal invoice
        //            break;
        //        default:
        //            throw new ArgumentOutOfRangeException();
        //            break;
        //    }
        //}

        private async Task<InvoiceBase> GetInvoiceByType(Order order, int invoiceId)
        {
            switch (order.Type)
            {
                case OrderType.Company:
                    return await _companyInvoiceRepo.GetAsync(invoiceId);
                    break;
                case OrderType.Personal:
                    return await _personalInvoiceRepo.GetAsync(invoiceId);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
                    break;
            }
        }
    }
}
