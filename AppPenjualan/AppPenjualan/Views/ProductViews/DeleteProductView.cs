using AppPenjualan.Applications.ProductServices;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Views.ProductViews
{
    public class DeleteProductView
    {
        private readonly IProductAppService _productAppService;
        public DeleteProductView(IProductAppService productAppService)
        {
            _productAppService = productAppService;
            
        }

        public void DisplayView()
        {
            Console.Clear();
            Console.WriteLine("Delete Product");
            Console.WriteLine("---------------------");

            Console.WriteLine("Input the product Id : ");
            var productId = Convert.ToInt32(Console.ReadLine());

            if (productId != null)
            {
                _productAppService.Delete(productId);
                Console.WriteLine("Delete Record Succesfully");
            }
        }
    }
}
