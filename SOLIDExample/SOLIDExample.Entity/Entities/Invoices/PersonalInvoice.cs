using SOLIDExample.Entity.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExample.Entity.Entities.Invoices
{
    [Table("PersonalInvoce")]
    public class PersonalInvoice : InvoiceBase
    {
        public PersonalInvoice() { }
        public PersonalInvoice(Order order) : base(order) { }
        public override void Sign()
        {
            //todo sign personal invoice
        }
        public override string Export()
        {
            return $"Exported Personal Invoice with {nameof(TotalCost)} : {TotalCost}";
        }
    }
}
