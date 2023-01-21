using AppPenjualan.Applications.Transactions;
using AppPenjualan.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Views.TransactionViews
{
    public class SearchTransactionView
    {
        private  ITransactionAppService _transactionAppService;
        public SearchTransactionView(ITransactionAppService transactionAppService)
        {
            _transactionAppService = transactionAppService;
        }

        public void DisplayView()
        {
            Console.Clear();

            Console.WriteLine("Search Transaction Code ");
            string searchStr = Console.ReadLine();

            Console.WriteLine("Enter Page  : ");
            var page = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Page Size :");
            var pageSize = Convert.ToInt32(Console.ReadLine());

            var pageInfo = new PageInfo(page, pageSize);
            var transactionList = _transactionAppService.SearchTransaction(searchStr, pageInfo);

            var totalPage = transactionList.Total / pageSize;

            Console.WriteLine($"Display Page : {page} with total page : {Math.Abs(totalPage)}");

            foreach (var transaction in transactionList.Data)
            {
                Console.WriteLine($"{transaction.TransactionCode} - {transaction.TransactionDate} - {transaction.Total} - " +
                    $"{transaction.Description} ");
            }
        }
    }
}
