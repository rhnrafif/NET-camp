using AppPenjualan.Applications.SupplierServices;
using AppPenjualan.Views.ProductViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Views.SupplierViews
{
    public class SupplierViews
    {
        private readonly ISupplierAppService _supplierAppService;
        private CreateSupplierView _createSupplierView;
        private UpdateSupplierView _updateSupplierView;
        private DeleteSupplierView _deleteSupplierView;
        private GetAllSupplierView _getAllSupplierView;
        public SupplierViews(ISupplierAppService supplierAppService, 
            CreateSupplierView createSupplierView,
            UpdateSupplierView updateSupplierView,
            DeleteSupplierView deleteSupplierView,
            GetAllSupplierView getAllSupplierView)
        {
            _supplierAppService = supplierAppService;
            _createSupplierView = createSupplierView;
            _updateSupplierView = updateSupplierView;
            _deleteSupplierView = deleteSupplierView;
            _getAllSupplierView = getAllSupplierView;
        }

        public void DisplayView()
        {
            bool showMenu = true;
            while (showMenu)
            {
                Console.Clear();
                Console.WriteLine("Choose An Option");
                Console.WriteLine("1. Create Supplier");
                Console.WriteLine("2. Update Supplier");
                Console.WriteLine("3. Delete Supplier");
                Console.WriteLine("4. Get All Supplier");
                Console.WriteLine("5. Exit");
                Console.Write("Select an Option : ");

                switch (Console.ReadLine())
                {
                    case "1":
                        //view
                        _createSupplierView.DisplayView();
                        showMenu = true;
                        break;
                    case "2":
                        //view
                        _updateSupplierView.DisplayView();
                        showMenu = true;
                        break;
                    case "3":
                        //view
                        _deleteSupplierView.DisplayView();
                        showMenu = true;
                        break;
                    case "4":
                        //view
                        _getAllSupplierView.DisplayView();
                        showMenu = true;
                        break;
                    case "5":
                        //view
                        showMenu = false;
                        break;
                    default:
                        //view
                        showMenu = true;
                        break;
                }


            }
        }
    }
}
