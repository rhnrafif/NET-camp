using LatihanEF.Customers;
using LatihanEF.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanEF.Views
{
    public class UpdateCustomerView
    {
        private readonly ICustomerService _customerService;
        public UpdateCustomerView(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public void DisplayView()
        {
            Console.Clear();
            Console.WriteLine("Update Customer");
            Console.WriteLine("-----------------------");
            Console.Write("Customer Name : ");
            var custName = Console.ReadLine();
            var resultName = _customerService.GetCustomerByName(custName);

            Console.WriteLine("-----------------------");
            Console.WriteLine("Current Record Detail");
            Console.WriteLine("-----------------------");

            Console.WriteLine($"Customer Id : {resultName.CostumerId}");
            Console.WriteLine($"Customer Name : {resultName.CustomerName}");
            Console.WriteLine($"Mobile Number : {resultName.MobileNumber}");

            Console.WriteLine("-----------------------");

            Console.Write("New Customer Name : ");
            string newName = Console.ReadLine();
            Console.Write("New Mobile Number : ");
            string newMobile = Console.ReadLine();
            Console.WriteLine("Note : UPDATE can't change Customer ID");
            Console.ReadKey();

            var customer = new Customer();
            customer.CostumerId = resultName.CostumerId;
            customer.CustomerName = newName;
            customer.MobileNumber = newMobile;

            _customerService.Update(customer);
            Console.WriteLine("Update Data Succesfully");
            Console.ReadKey();
        }
    }
}
