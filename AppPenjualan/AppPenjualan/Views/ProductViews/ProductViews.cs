using AppPenjualan.Applications.ProductServices;
using AppPenjualan.Helpers;
using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Views.ProductViews
{
    public class ProductViews
    {
        private CreateProductView _createProductView;
        private UpdateProductView _updateProductView;
        private DeleteProductView _deleteProductView;
        private GetAllProductList _getAllProductList;
        private SearchProductView _searchProductView;
       
        public ProductViews(
            CreateProductView createProductView, 
            UpdateProductView updateProductView, 
            DeleteProductView deleteProductView,
            GetAllProductList getAllProductList,
            SearchProductView searchProductView)
        {
            _createProductView = createProductView;
            _updateProductView = updateProductView;
            _deleteProductView = deleteProductView;
            _getAllProductList = getAllProductList;
            _searchProductView = searchProductView;
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

                //Console.WriteLine("Enter Page Number : ");
                //var page = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Page Size :");
                //var pageSize = Convert.ToInt32(Console.ReadLine());

                //var pageInfo = new PageInfo(page, pageSize);
                //var productList = _productAppService.GetAllProducts(pageInfo);

                //decimal totalPage = productList.Total / pageSize;

                //Console.WriteLine($"Display Page : {page} with total page : {(int)(Math.Ceiling(totalPage))}");

                //foreach (var product in productList.Data)
                //{
                //    Console.WriteLine($"{product.ProductCode} - {product.ProductName} - {product.ProductPrice} - " +
                //        $"{product.ProductQty} - {product.SupplierName} ");
                //}

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
                    Console.WriteLine("1. Create Product");
                    Console.WriteLine("2. Update Product");
                    Console.WriteLine("3. Delete Product");
                    Console.WriteLine("4. Select Page");
                    Console.WriteLine("5. Search product View ");
                    Console.WriteLine("6. Exit");
                    Console.Write("Select an Option : ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            //view
                            _createProductView.DisplayView();
                            showMenu = true;
                            break;
                        case "2":
                            //view
                            _updateProductView.DisplayView();
                            showMenu = true;
                            break;
                        case "3":
                            //view
                            _deleteProductView.DisplayView();
                            showMenu = true;
                            break;
                        case "4":
                            //view
                            _getAllProductList.DisplayView();
                            showMenu = true;
                            break;
                        case "5":
                            //view
                            _searchProductView.DisplayView(); 
                            showMenu = true;
                            break;
                        case "6":
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
