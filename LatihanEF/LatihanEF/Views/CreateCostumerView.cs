using LatihanEF.Customers;
using LatihanEF.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanEF.Views
{
    public class CreateCostumerView
    {
        private readonly ICustomerService _costumerService;
        public CreateCostumerView(ICustomerService customerService)
        {
            _costumerService = customerService;
        }

        public void DisplayView()
        {
            Console.WriteLine("Create Customer App");
            Console.WriteLine("---------------------");
            //Console.Write("Customer Id : ");
            //var cosId = int.Parse(Console.ReadLine());
            Console.Write("Costumer Name : ");
            var cosName = Console.ReadLine();
            Console.Write("Mobile Number : ");
            string mobNum = Console.ReadLine();

            Customer customer = new Customer();
            //customer.CostumerId = cosId;
            customer.CustomerName = cosName;
            customer.MobileNumber = mobNum;

            _costumerService.Insert(customer);

        }
    }
}
