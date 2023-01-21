using LatihanEF.Customers;
using LatihanEF.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanEF.Views
{
    
    public class GetAllCustomer
    {
        private readonly ICustomerService _customerService;
        public GetAllCustomer(ICustomerService customerService)
        {
            _customerService = customerService;
        }   
        public void DisplayView()
        {
            var result = _customerService.GetAllCustomer();

            Console.Clear();
            Console.WriteLine("List of all Customer");
            Console.WriteLine("----------------------");
            foreach(Customer customer in result)
            {
                Console.Write($"Customer Id : {customer.CostumerId} | ");
                Console.Write($"Customer Name : {customer.CustomerName} | ");
                Console.Write($"Customer Id : {customer.MobileNumber}");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
