using AppPenjualan.Applications.ProductServices;
using AppPenjualan.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Views.ProductViews
{
    public class SearchProductView
    {
        private IProductAppService _productAppService;

        public SearchProductView(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }
        public void DisplayView()
        {
            bool showMenu = true;
            int recordPerPage = 4;
            int pageNumber = 0;
            do
            {
                //Get All Product Here
                //fitur search, order by, pagonation
                Console.Clear();

                Console.WriteLine("Search Product By Name or Code ");
                string searchStr = Console.ReadLine();

                Console.WriteLine("Enter Page Number : ");
                var page = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Page Size :");
                var pageSize = Convert.ToInt32(Console.ReadLine());

                var pageInfo = new PageInfo(page, pageSize);
                var productList = _productAppService.SearchProduct(searchStr, pageInfo);

                var totalPage = productList.Total / pageSize;

                Console.WriteLine($"Display Page : {page} with total page : {Math.Abs(totalPage)}");

                foreach (var product in productList.Data)
                {
                    Console.WriteLine($"{product.ProductCode} - {product.ProductName} - {product.ProductPrice} - " +
                        $"{product.ProductQty} - {product.SupplierName} ");
                }
                Console.WriteLine("Press Any key to exit");
                Console.ReadKey();



            } while (showMenu);


        }
    }
}
