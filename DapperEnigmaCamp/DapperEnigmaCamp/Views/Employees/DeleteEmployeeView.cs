using DapperEnigmaCamp.Aplications.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperEnigmaCamp.Views.Employees
{
    public class DeleteEmployeeView
    {
        private readonly IEmployeeAppService _empAppService;
        public DeleteEmployeeView(IEmployeeAppService empEmployeeService)
        {
            _empAppService = empEmployeeService;
        }

        public void DisplayView()
        {
            Console.Clear();
            Console.WriteLine("Delete Employee");
            Console.WriteLine("------------------");

            Console.WriteLine("Input Employee Id :");
            var employeeId = Console.ReadLine();
            var resultEmp = _empAppService.GetModelById(Guid.Parse(employeeId));

            if (resultEmp != null)
            {
                Console.WriteLine($"Employee Name : {resultEmp.EmployeeName}");
                Console.WriteLine($"Salary : {resultEmp.Salary}");
                Console.WriteLine($"Company : {resultEmp.CompanyId}");
                Console.WriteLine($"Division : {resultEmp.DivisionId}");
                Console.WriteLine($"Departement : {resultEmp.DepartmentId}");

                Console.WriteLine("Are you sure to Delete this record ? (Y/N)");
                var choice = Console.ReadLine();
                _empAppService.Delete(resultEmp.EmployeeId);

            }
        }
    }
}
