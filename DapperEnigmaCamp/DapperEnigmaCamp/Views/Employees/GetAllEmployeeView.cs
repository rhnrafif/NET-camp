﻿using DapperEnigmaCamp.Aplications.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperEnigmaCamp.Views.Employees
{

    public class GetAllEmployeeView
    {
        private readonly IEmployeeAppService _empAppService;
        public GetAllEmployeeView(IEmployeeAppService empAppService)
        {
            _empAppService = empAppService;
        }

        public void DisplayView()
        {
            Console.Clear();
            Console.WriteLine("List All Employee");
            var listEmployee = _empAppService.GetAllEmployee();
            foreach(var employee in listEmployee)
            {
                Console.WriteLine($"{employee.EmployeeId} - {employee.EmployeeName} " +
                    $"{employee.CompanyName} - {employee.DivisionName} - {employee.DepartmentName}");
            }
            Console.ReadKey();
        }
    }
}
