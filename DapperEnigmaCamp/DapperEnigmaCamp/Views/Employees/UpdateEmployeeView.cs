using DapperEnigmaCamp.Aplications.Employees;
using DapperEnigmaCamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperEnigmaCamp.Views.Employees
{
    public class UpdateEmployeeView
    {
        private readonly IEmployeeAppService _empAppService;

        public UpdateEmployeeView(IEmployeeAppService empAppService)
        {
            _empAppService = empAppService;

        }
        public void DisplayView()
        {


            Console.Clear();
            Console.WriteLine("Update Employee");
            Console.WriteLine("------------------");

            Console.WriteLine("Input Employee Id :");
            var employeeId = Console.ReadLine();
            var resultEmp = _empAppService.GetModelById(Guid.Parse(employeeId));

            if(resultEmp != null)
            {
                Console.WriteLine($"Employee Name : {resultEmp.EmployeeName}");
                Console.WriteLine($"Salary : {resultEmp.Salary}");
                Console.WriteLine($"Company : {resultEmp.CompanyId}");
                Console.WriteLine($"Division : {resultEmp.DivisionId}");
                Console.WriteLine($"Departement : {resultEmp.DepartmentId}");

                Console.WriteLine("Are you sure to Update this record ? (Y/N)");
                var choice = Console.ReadLine();

                if (choice.ToUpper().Equals("Y"))
                {

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

                    employee.EmployeeId = resultEmp.EmployeeId;
                    employee.EmployeeName = empName;
                    employee.Salary = salary;
                    employee.CompanyId = Guid.Parse(companyId);
                    employee.DivisionId = Guid.Parse(divisionId);
                    employee.DepartmentId = Guid.Parse(departmentId);


                    _empAppService.Update(employee);

                }
            }
        }
    }
}
