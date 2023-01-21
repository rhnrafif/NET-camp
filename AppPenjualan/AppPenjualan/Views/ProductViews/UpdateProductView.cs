using AppPenjualan.Applications.ProductServices;
using AppPenjualan.Applications.ProductServices.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Views.ProductViews
{
    public class UpdateProductView
    {
        private readonly IProductAppService _productAppService;
        public UpdateProductView(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        public void DisplayView()
        {
            Console.Clear();
            Console.WriteLine("Update Product");
            Console.WriteLine("---------------");

            Console.WriteLine("Input product Code :");
            string codeProduct = Console.ReadLine();

            var product = _productAppService.GetProductByCode(codeProduct);

            if(product != null)
            {

                Console.WriteLine($"Product Code : {product.ProductCode}");
                Console.WriteLine($"Product Name : {product.ProductName}");
                Console.WriteLine($"Product Price : {product.ProductPrice}");
                Console.WriteLine($"Product Qty : {product.ProductQty}");

                Console.WriteLine("------------------------------------");


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

                Console.Write("Are you sure want to Update this Record ? (Y/N) : ");

                if(Console.ReadLine().ToUpper() == "Y")
                {
                    var productUpdate = new UpdateProductDto
                    {
                        ProductCode = code,
                        ProductName = name,
                        ProductPrice = price,
                        ProductQty = qty,
                        SuppliersId = supId
                    };

                    _productAppService.Update(productUpdate);
                    Console.WriteLine("Update Record Succesfully");
                    Console.ReadKey();
                }

            }

            
        }
    }
}
