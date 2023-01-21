using AppPenjualan.Applications.ProductServices;
using AppPenjualan.Applications.ProductServices.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Views.ProductViews
{
    public class CreateProductView
    {
        private readonly IProductAppService _productAppService;
        public CreateProductView(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }
        public void DisplayView()
        {
            Console.Clear();
            Console.WriteLine("Create Product");
            Console.WriteLine("---------------");

            Console.Write("Product Code : ");
            string code = Console.ReadLine();
            Console.Write("Product Name : ");
            string name = Console.ReadLine();
            Console.Write("Product Price : ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Product Qty : ");
            int qty = Convert.ToInt32(Console.ReadLine());
            Console.Write("Supplier Id : ");
            int supId = Convert.ToInt32(Console.ReadLine());

            var crateProduct = new CreateProductDto()
            {
                ProductCode = code,
                ProductName = name,
                ProductPrice = price,
                ProductQty = qty,
                SuppliersId = supId
            
            };

            _productAppService.Create(crateProduct);
            Console.WriteLine("Record Saved");
            Console.ReadKey();

        }
    }
}
