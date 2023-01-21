using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperEnigmaCamp.Aplications.Dto
{
    public class EmployeeDto
    {
        public string EmployeeName { get; set; }
        public Guid EmployeeId { get; set; }
        public string CompanyName { get; set; }
        public string DepartmentName { get; set; }
        public string DivisionName { get; set; }
    }
}
