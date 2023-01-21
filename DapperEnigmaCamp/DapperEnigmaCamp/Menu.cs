using DapperEnigmaCamp.Aplications.Companies;
using DapperEnigmaCamp.Aplications.Employees;
using DapperEnigmaCamp.Views.Companies;
using DapperEnigmaCamp.Views.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperEnigmaCamp
{
    public class Menu
    {
        public void EmployeeMenu()
        {
            var empAppService = new EmployeeAppService();
            bool showMenu = true;
            while (showMenu)
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Create Employee");
                Console.WriteLine("2) Update Employee");
                Console.WriteLine("3) Delete Employee");
                Console.WriteLine("4) Get All Employee");
                Console.WriteLine("5) Exit");
                Console.Write("\r\nSelect an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        //view
                        var createEmpView = new CreateEmployeeView(empAppService);
                        createEmpView.DisplayView();
                        showMenu = true;
                        break;
                    case "2":
                        //view
                        var updateEmpView = new UpdateEmployeeView(empAppService);
                        updateEmpView.DisplayView();
                        break;
                    case "3":
                        //view
                        var deleteEmpView = new DeleteEmployeeView(empAppService);
                        deleteEmpView.DisplayView();
                        showMenu = true;
                        break;
                    case "4":
                        //view
                        var getAllEmpView = new GetAllEmployeeView(empAppService);
                        getAllEmpView.DisplayView();
                        break;
                    case "5":
                        //view
                        showMenu = false;
                        break;
                    default:
                        showMenu = true;
                        break;
                }
            }
        }
        public void CompanyMenu()
        {
            var compAppService = new CompanyAppService();
            bool showMenu = true;
            while (showMenu)
            {
                Console.Clear();
                Console.WriteLine("Choose an Option");
                Console.WriteLine("1) Create Company");
                Console.WriteLine("2) Update Company");
                Console.WriteLine("3) Delete Company");
                Console.WriteLine("4) Exit");
                Console.Write("\r\nSelect an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        var createCompView = new CreateCompanyView(compAppService);
                        createCompView.DisplayView();
                        showMenu = true;
                        break;
                    case "2":
                        //view
                        showMenu= true;
                        break;
                    case "3":
                        //view
                        showMenu = true;
                        break;
                    case "4":
                        //view
                        showMenu = false;
                        break;

                }
            }
        }
    }
}
