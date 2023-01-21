using AppPenjualan.Applications.SupplierServices;
using AppPenjualan.Applications.SupplierServices.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Views.SupplierViews
{
    public class UpdateSupplierView
    {
        private readonly ISupplierAppService _supplierAppService;
        public UpdateSupplierView(ISupplierAppService supplierAppService)
        {
            _supplierAppService = supplierAppService;
        }

        public void DisplayView()
        {
            Console.Clear();
            Console.WriteLine("Update Supplier");
            Console.WriteLine("------------------");
            Console.Write("Supplier Name : ");
            string supName = Console.ReadLine();

            var supplier = _supplierAppService.GetSupplierByName(supName);

            if(supplier == null)
            {
                Console.WriteLine("Record Was Not Found ! Please try again");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine("Supplier Record");
            Console.WriteLine("---------------------------");

            Console.WriteLine($"Supplier Name : {supplier.SupplierName} ");
            Console.WriteLine($"Supplier Address : {supplier.SupplierAddress} ");
            Console.WriteLine($"Supplier Address : {supplier.SuppliersId} ");

            Console.WriteLine("---------------------------");
            Console.WriteLine("Please Input Update Field");
            Console.WriteLine("---------------------------");

            Console.Write("Suplier Name : ");
            string name = Console.ReadLine();
            Console.Write("Supplier Address : ");
            string address = Console.ReadLine();

            var supplierDto = new UpdateSupplierDto
            {
                SupplierName = name,
                SupplierAddress = address,
            };
            _supplierAppService.UpdateSupplier(supplierDto, supplier.SupplierName);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Update Supplier Succesfully");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
