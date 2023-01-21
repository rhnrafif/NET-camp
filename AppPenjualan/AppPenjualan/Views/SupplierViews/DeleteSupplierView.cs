using AppPenjualan.Applications.SupplierServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Views.SupplierViews
{
    public class DeleteSupplierView
    {
        private readonly ISupplierAppService _supplierAppService;
        public DeleteSupplierView(ISupplierAppService supplierAppService)
        {
            _supplierAppService = supplierAppService;
        }

        public void DisplayView()
        {
            Console.Clear();
            Console.WriteLine("Delete Supplier");
            Console.WriteLine("-----------------");
            Console.Write("Supplier Name : ");
            var name = Console.ReadLine();

            var supplier = _supplierAppService.GetSupplierByName(name);

            if(supplier == null)
            {
                Console.WriteLine();
                Console.WriteLine("Record Was Not Found! Please try again");
                Console.ReadKey();
                return;
            }
                int id = supplier.SuppliersId;

                if (id != null)
                {
                    _supplierAppService.DeleteSupplier(id);
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("Delete Record Succesfully");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey();
                }
            
        }
    }
}
