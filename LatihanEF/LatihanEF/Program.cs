using LatihanEF.Customers;
using LatihanEF.Database;
using LatihanEF.Views;
using Microsoft.IdentityModel.Tokens;

class Program
{
    
    static void Main()
    {
        //instance dr interface
        ICustomerService customerService = new CustomerService();

        bool showMenu = true;
        while (showMenu)
        {
            Console.Clear();
            Console.WriteLine("Customer App");
            Console.WriteLine("-----------------");
            Console.WriteLine("Choose your option : ");
            Console.WriteLine("1. Create Customer");
            Console.WriteLine("2. Delete Customer");
            Console.WriteLine("3. Update Customer");
            Console.WriteLine("4. Get All List Customer");
            Console.WriteLine("5. Get Customer By Name");
            Console.WriteLine("6. Exit");
            Console.Write("Your Option : ");

            switch (Console.ReadLine())
            {
                case "1":
                    //view
                    CreateCostumerView custView = new CreateCostumerView(customerService);
                    custView.DisplayView();
                    showMenu = true;
                    break;
                case "2":
                    //view\
                    DeleteCustomerView custDelete = new DeleteCustomerView(customerService);
                    custDelete.DisplayView();
                    showMenu = true;
                    break;
                case "3":
                    //view
                    UpdateCustomerView custUpdate = new UpdateCustomerView(customerService);
                    custUpdate.DisplayView();
                    showMenu = true;
                    break;
                case "4":
                    //view
                    GetAllCustomer getCustomer = new GetAllCustomer(customerService);
                    getCustomer.DisplayView();
                    showMenu = true;
                    break;
                case "5":
                    //view
                    GetCustomerByIdView getCustByName = new GetCustomerByIdView(customerService);
                    getCustByName.DisplayView();
                    showMenu = true;
                    break;
                case "6":
                    showMenu = false;
                    break;
                default:
                    showMenu = true;
                    break;
            }

        }
    }
}