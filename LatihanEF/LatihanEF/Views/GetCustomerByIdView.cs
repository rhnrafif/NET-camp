using LatihanEF.Customers;
using LatihanEF.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanEF.Views
{
    public class GetCustomerByIdView
    {
        private readonly ICustomerService _customerService;
        public GetCustomerByIdView(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public void DisplayView()
        {
            Console.Clear();
            Console.WriteLine("Select Customer by Id");
            Console.WriteLine("-----------------------");
            
            Console.Write("Customer Name : ");
            var inputName = Console.ReadLine();

            var result = _customerService.GetCustomerByName(inputName);

            Console.WriteLine("Customer Details ");
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Id            : { result.CostumerId}");
            Console.WriteLine($"Name          : { result.CustomerName}");
            Console.WriteLine($"Mobile Number : { result.MobileNumber}");
            Console.WriteLine("-----------------------");

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
