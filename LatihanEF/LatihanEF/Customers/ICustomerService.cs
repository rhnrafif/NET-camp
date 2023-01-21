using LatihanEF.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanEF.Customers
{
    public interface ICustomerService
    {
        void Insert(Customer customer);
        void Update(Customer customer);
        void Delete(int Id);
        List<Customer> GetAllCustomer();
        Customer GetCustomerByName(string name);
    }
}
