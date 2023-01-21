using AppPenjualan.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Views.ReportViews
{
   
    public class ReportView
    {
        private SalesContext _salesContext;
        public ReportView(SalesContext salesContext)
        {
            _salesContext = salesContext;
        }

        public void DisplayView()
        {
            Console.Clear();
            var Data = (from a in _salesContext.Transactionns
                        join b in _salesContext.TransactionDetails
                            on a.TransactionsId equals b.TransactionsId
                        join c in _salesContext.Products
                            on b.ProductsId equals c.ProductsId
                        join d in _salesContext.Suppliers
                            on c.SuppliersId equals d.SuppliersId
                        select new
                        {
                            Code = a.TransactionCode,
                            Date = a.TransactionDate,
                            Total = a.Total,
                            Product = c.ProductName,
                            Qty = b.Qty,
                            Subtotal = b.SubTotal
                        });
            foreach(var transaction in Data)
            {
                Console.WriteLine($"{transaction.Code} - {transaction.Date} - {transaction.Total} - {transaction.Product} - {transaction.Qty} - {transaction.Subtotal}");

            }
            Console.ReadKey();
        }
    }
}
