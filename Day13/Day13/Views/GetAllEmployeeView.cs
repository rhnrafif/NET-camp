using Day13.Applications.Employees;
using Day13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13.Views
{
    public class GetAllEmployeeView
    {
        private EmployeeAppService _employeeAppService;
        public GetAllEmployeeView(EmployeeAppService employeeAppService)
        {
            _employeeAppService = employeeAppService;
        }

        public void DisplayView()
        {
            Console.WriteLine("Get All Employee");
            Console.WriteLine("-----------------");

            var data = _employeeAppService.GetAllEmployee();

            foreach (var item in data)
            {
                Console.WriteLine(item.EmployeeId + ",  " + item.EmployeeName + ",  " + item.Salary);
            }

            Console.ReadKey();
        }
    }
}
