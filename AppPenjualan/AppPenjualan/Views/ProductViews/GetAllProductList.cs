using AppPenjualan.Applications.ProductServices;
using AppPenjualan.Helpers;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Views.ProductViews
{
    public class GetAllProductList
    {
        private readonly IProductAppService _productAppService;
        public GetAllProductList(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        public void DisplayView()
        {
            Console.Clear();
            Console.Write("Enter Page Number : ");
            var page = Convert.ToInt32(Console.ReadLine());
            Console.Write("Page Size : ");
            var pageSize = Convert.ToInt32(Console.ReadLine());

            var pageInfo = new PageInfo(page, pageSize);

            var listData = _productAppService.GetAllProducts(pageInfo);
            
            foreach (var product in listData.Data )
            {
                Console.WriteLine($"{product.ProductCode} - {product.ProductName} - {product.ProductPrice} - {product.ProductQty} - {product.SupplierName}");
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

    }
}
