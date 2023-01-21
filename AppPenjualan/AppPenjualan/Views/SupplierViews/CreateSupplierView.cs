using AppPenjualan.Applications.SupplierServices;
using AppPenjualan.Applications.SupplierServices.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Views.SupplierViews
{
    public class CreateSupplierView
    {
        private readonly ISupplierAppService _supplierAppService;
        public CreateSupplierView(ISupplierAppService supplierAppService)
        {
            _supplierAppService = supplierAppService;
        }

        public void DisplayView()
        {
            Console.Clear();
            Console.WriteLine("Create Supplier");
            Console.WriteLine("---------------");

            Console.Write("Suplier Name : ");
            string name = Console.ReadLine();
            Console.Write("Supplier Address : ");
            string address = Console.ReadLine();

            var supplierDto = new CreateSupplierDto
            {
                SupplierName = name,
                SupplierAddress = address
            };
            _supplierAppService.CreateSupplier(supplierDto);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Create Supplier Succesfully");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
