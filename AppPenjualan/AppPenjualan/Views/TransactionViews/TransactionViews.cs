using AppPenjualan.Applications.TransactionDetailServices;
using AppPenjualan.Applications.Transactions;
using AppPenjualan.Views.ProductViews;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Views.TransactionViews
{
    public class TransactionViews
    {
        private ITransactionAppService _transactionAppService;
        private ITransactionDetailAppService _transactionDetailAppService;
        private CreateTransactionView _createTransactionView;
        private SearchTransactionView _searchTransactionView;
        
        public TransactionViews(ITransactionAppService transactionAppService, 
            ITransactionDetailAppService transactionDetailAppService,
            CreateTransactionView createTransactionView,
            SearchTransactionView searchTransactionView)
        {
            _transactionAppService = transactionAppService;
            _transactionDetailAppService = transactionDetailAppService;
            _createTransactionView = createTransactionView;
            _searchTransactionView = searchTransactionView;
        }

        public void DisplayView()
        {
            //Startup startup = new Startup();
            //var createTranView = startup.Provider.GetService<CreateTransactionView>();
            //var searchView = startup.Provider.GetService<SearchTransactionView>();


            bool showMenu = true;
            int recordPerPage = 4;
            int pageNumber = 0;
            do
            {
                #region Hide
                //if(int.TryParse(Console.ReadLine(), out pageNumber))
                //{
                //    if (pageNumber > 0 && pageNumber < 5)
                //    {
                //        var productList = _productAppService.GetAllProducts()
                //            .Skip((pageNumber - 1) * recordPerPage)
                //            .Take(recordPerPage)
                //            .ToList();


                //    }
                //}

                #endregion

                while (showMenu)
                {
                    Console.Clear();
                    Console.WriteLine("Choose An Option");
                    Console.WriteLine("1. Create Transaction");
                    Console.WriteLine("2. Search Transaction ");
                    Console.WriteLine("3. Exit");
                    Console.Write("Select an Option : ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            //view
                            _createTransactionView.DisplayView();
                            showMenu = true;
                            break;
                        case "2":
                            //view
                            _searchTransactionView.DisplayView();
                            showMenu = true;
                            break;
                        case "3":
                            //view
                            showMenu = false;
                            break;
                        default:
                            //view
                            showMenu = true;
                            break;
                    }


                }
            } while (showMenu);


        }


    }
}
