using AppPenjualan.Applications.SupplierServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Views.SupplierViews
{
    public class GetAllSupplierView
    {
        private readonly ISupplierAppService _supplierAppService;
        public GetAllSupplierView(ISupplierAppService supplierAppService)
        {
            _supplierAppService = supplierAppService;
        }
        public void DisplayView()
        {
            var listSupplier = _supplierAppService.GetAllSupplier();

            if(listSupplier == null)
            {
                Console.WriteLine("No Record for this Table");
                Console.ReadKey();
                return;
            }

            int pageNumber = 0;

            Console.Write("How many record you want to see ? : ");
            int recordPerPage = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Page Number : ");
            var page = Console.ReadLine();

            if (int.TryParse(page, out pageNumber))
            {
                if (pageNumber > 0 && recordPerPage < pageNumber)
                {
                    pageNumber = recordPerPage;

                }

                if (pageNumber > 0 && pageNumber <= recordPerPage)
                {
                    var suppliers = listSupplier.Skip((pageNumber - 1) * recordPerPage)
                        .Take(recordPerPage).ToList();

                    Console.WriteLine("List Supplier");
                    Console.WriteLine("-------------------------");
                    foreach (var supplier in suppliers)
                    {
                        Console.WriteLine($"{supplier.SupplierName} - {supplier.SupplierAddress}");
                    }
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey();
                }
            }
        }
    }
}
