using DapperEnigmaCamp.Aplications.Employees;
using DapperEnigmaCamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperEnigmaCamp.Views.Employees
{
    public class CreateEmployeeView
    {
        private readonly IEmployeeAppService _empAppService;
        //konstruktor
        public CreateEmployeeView(IEmployeeAppService empAppService)
        {
            _empAppService = empAppService;
        }
        public void DisplayView()
        {
            Console.Clear();
            Console.WriteLine("Create Employee");
            Console.WriteLine("------------------");

            Console.Write("Employee Name : ");
            var empName = Console.ReadLine();
            Console.Write("Salary : ");
            int salary = int.Parse(Console.ReadLine());
            Console.Write("Company Name : ");
            string companyId = Console.ReadLine();
            Console.Write("Division Name : ");
            string divisionId = Console.ReadLine();
            Console.Write("Department Name : ");
            string departmentId = Console.ReadLine();

            var employee = new Employee();

            Guid guid = Guid.NewGuid(); //untuk uniqueidentifier
            employee.EmployeeId = guid;
            employee.EmployeeName = empName;
            employee.Salary = salary;
            employee.CompanyId = Guid.Parse(companyId);
            employee.DivisionId = Guid.Parse(divisionId);
            employee.DepartmentId = Guid.Parse(departmentId);


            _empAppService.Insert(employee);

        }
    }
}
