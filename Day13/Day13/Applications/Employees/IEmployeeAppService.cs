using Day13.Models;
using Day13.Applications.Employees.Dto;
using Day13.Models;
namespace Day13.Applications.Employees
{
    public interface IEmployeeAppService
    {
        void SaveEmp(Employee emp);
        void UpdateEmp(Employee emp);
        void DeleteEmp(string id);
        EmployeeDto GetById(string id);
        List<EmployeeDto> GetAllEmployee();
    }
}
