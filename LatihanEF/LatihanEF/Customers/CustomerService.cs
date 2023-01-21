using LatihanEF.Database;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanEF.Customers
{
    public class CustomerService : ICustomerService
    {
        public void Delete(int Id)
        {
            var context = new ShopContext();
            var custData = context.Customers.FirstOrDefault(w => w.CostumerId == Id);
            context.Remove(custData);
            context.SaveChanges();
        }

        public List<Customer> GetAllCustomer()
        {
            var context = new ShopContext();
            var result = context.Customers.ToList();
            return result;
        }

        public Customer GetCustomerByName(string name)
        {
            var customer = new Customer();
            var context = new ShopContext();
            customer = context.Customers.FirstOrDefault(w => w.CustomerName.ToUpper() == name.ToUpper());
            return customer;
        }

        public void Insert(Customer customer)
        {
            var customers = new Customer();
            //customers.CostumerId = customer.CostumerId;
            customers.CustomerName = customer.CustomerName;
            customers.MobileNumber = customer.MobileNumber;

            var context = new ShopContext();
            try
            {
                context.Database.BeginTransaction();
                context.Add<Customer>(customer);
                context.SaveChanges();
                context.Database.CommitTransaction();

                Console.WriteLine("Insert Record Succesfully");
                Console.ReadKey();
            }
            catch (DbException de)
            {
                Console.WriteLine($"An Error Occured ! {de.Message}");
                context.Database.RollbackTransaction();
            }
        }

        public void Update(Customer customer)
        {
            var context = new ShopContext();
            //var custData = context.Customers.Where(w => w.CustomerName == customer.CustomerName);

            context.Update(customer);
            context.SaveChanges();
        }
    }
}
