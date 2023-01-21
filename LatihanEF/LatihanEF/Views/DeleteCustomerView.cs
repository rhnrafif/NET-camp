using LatihanEF.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanEF.Views
{
    public class DeleteCustomerView
    {
        private readonly ICustomerService _customerService;
        public DeleteCustomerView(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public void DisplayView()
        {
            Console.Clear();
            Console.WriteLine("Delete Customer");
            Console.WriteLine("-------------------");
            Console.WriteLine("Customer Name : ");
            var custName = Console.ReadLine();
            var resultName = _customerService.GetCustomerByName(custName);

            Console.WriteLine($"Customer Id : {resultName.CostumerId}");
            Console.WriteLine($"Customer Name : {resultName.CustomerName}");
            Console.WriteLine($"Mobile Number : {resultName.MobileNumber}");

            Console.WriteLine("Are you sure to DELETE this record ? (Y/N)");
            
            while(Console.ReadLine().ToUpper() == "Y")
            {
                _customerService.Delete(resultName.CostumerId);
                Console.WriteLine("DELETE Succesfully!" );
                Console.ReadKey();
            }
        }
    }
}
