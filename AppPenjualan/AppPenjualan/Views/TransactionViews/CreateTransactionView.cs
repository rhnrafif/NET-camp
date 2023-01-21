using AppPenjualan.Applications.ProductServices;
using AppPenjualan.Applications.TransactionDetailServices;
using AppPenjualan.Applications.TransactionDetailServices.Dto;
using AppPenjualan.Applications.Transactions;
using AppPenjualan.Applications.Transactions.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Views.TransactionViews
{
    public class CreateTransactionView
    {
        private ITransactionAppService _transactionAppService;
        private ITransactionDetailAppService _transactionDetailAppService;
        private IProductAppService _productAppService;

        public CreateTransactionView(ITransactionAppService transactionAppService, 
            ITransactionDetailAppService transactionDetailAppService,
            IProductAppService productAppService)
        {
            _transactionAppService = transactionAppService;
            _transactionDetailAppService = transactionDetailAppService;
            _productAppService = productAppService;
        }

        public void DisplayView()
        {
            Console.Clear();
            Console.WriteLine("Create Transaction");
            Console.WriteLine("-------------------");

            var createTransaction = new CreateTransactionDto();
            createTransaction.TransactionDate = DateTime.Now;
            createTransaction.Total = 1000;
            createTransaction.Description = "ASc";

            var tranId = _transactionAppService.Create(createTransaction);
            var total = 0;
            bool repeat = true;


            while (true)
            {
                Console.Write("Masukan Product : ");
                string code = Console.ReadLine();

                //search code
                var product = _productAppService.GetProductByCode(code);

                Console.Write("Masukan Qty : ");
                var qty = Convert.ToInt32(Console.ReadLine());
                int subTotal = product.ProductPrice * qty;
                 total = total + subTotal;

                var transDetail = new CreateTransactionDetailDto();
                transDetail.TransactionsId = tranId;
                transDetail.ProductsId = product.ProductsId;
                transDetail.Qty = qty;
                transDetail.SubTotal = subTotal;

                //create transdetail
                _transactionDetailAppService.Create(transDetail);
                _transactionAppService.UpdateTotal(tranId, total);

                Console.Write("Apapakah Ingin Input Lagi ? Y/N : ");
                var choice = Console.ReadLine();
                if (choice.ToUpper().Equals("Y"))
                {
                    repeat = true;
                }
                else
                    repeat = false;


            }

        }
    }
}
