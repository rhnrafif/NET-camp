using SOLIDExample.Entity.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExample.Entity.Entities.Invoices
{
    [Table("CompanyInvoice")]
    public class CompanyInvoice : InvoiceBase
    {
        public int TaxNumber { get; set; }
        public CompanyInvoice() { }
        public CompanyInvoice(Order order, int taxNumber) : base(order)
        {
            TaxNumber = taxNumber;
        }

        public override void Sign()
        {
            //todo sign company
        }

        public override string Export()
        {
            //todo exporting company
            return $"Export Company invoice with {nameof(TotalCost)} : {TotalCost}, {nameof(TaxNumber)} : {TaxNumber}";
        }
    }
}
