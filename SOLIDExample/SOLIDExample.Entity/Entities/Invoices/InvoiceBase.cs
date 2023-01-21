using SOLIDExample.Entity.Orders;
using SOLIDExample.Entity.SeedWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExample.Entity.Entities.Invoices
{
    public abstract class InvoiceBase : EntityBase
    {
        public Order Order { get; set; }
        public decimal TotalCost { get; set; }
        public abstract void Sign();
        protected InvoiceBase() { }
        protected InvoiceBase(Order order)
        {
            Order = order;
            TotalCost = order.Total();
        }

        public virtual string Export()
        {
            return $"Export invoice with {nameof(TotalCost)} : {TotalCost} ";
        }

    }
}
