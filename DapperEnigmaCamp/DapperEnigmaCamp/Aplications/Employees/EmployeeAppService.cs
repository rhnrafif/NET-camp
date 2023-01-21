using Dapper;
using DapperEnigmaCamp.Aplications.Dto;
using DapperEnigmaCamp.Models;
using DapperEnigmaCamp.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperEnigmaCamp.Aplications.Employees
{
    public class EmployeeAppService : IEmployeeAppService
    {
        private readonly string connString = @"Server=RHNRAFIF\SQLEXPRESS;Database=ShipDB;Trusted_Connection=True;";


        public List<EmployeeDto> GetAllEmployee()
        {
            List<EmployeeDto> listEmployeeDto = new List<EmployeeDto>();
            using (var connection = new SqlConnection(connString))
            {
                connection.Open();
                try
                {
                    listEmployeeDto = connection.Query<EmployeeDto>(@"SELECT * FROM Employee").ToList();
                }
                catch (DbException de)
                {
                    Console.WriteLine($"An Error {de.Message}");
                }

                connection.Close();
            }
            return listEmployeeDto;
        }

        public EmployeeDto GetById(Guid Id)
        {
            var employeeDto = new EmployeeDto();
            using (var connection = new SqlConnection(connString))
            {
                connection.Open();

                var listEmployeeDto = connection.Query<EmployeeDto>(@"SELECT emp.EmployeeId, emp.EmployeeName, " +
                    "comp.CompanyName, div.DivisionName, dept.DepartmentName FROM Employee emp " +
                    " JOIN Company comp ON emp.CompanyId = comp.CompanyId" +
                    "JOIN Division div ON emp.DivisionId = div.DivisonId" +
                    "JOIN Department dept ON emp.DepartmentId = dept.DepartmentId" +
                    "WHERE EmployeeId = @Id", new { Id }).ToList();

                employeeDto = listEmployeeDto.FirstOrDefault();
                connection.Close();
            }


            return employeeDto;
        }

        public Employee GetModelById(Guid Id)
        {
            var employee = new Employee();
            using (var connection = new SqlConnection(connString))
            {
                connection.Open();

                var listEmployee = connection.Query<Employee>(@"SELECT * FROM Employee WHERE EmployeeId = @id", new { id = Id }).ToList();

                employee = listEmployee.FirstOrDefault();
                connection.Close();
            }
            return employee;
        }

        public void Insert(Employee employee)
        {
            using (var connection = new SqlConnection(connString))
            {
                connection.Open();
                var transaction = connection.BeginTransaction();
                try
                {
                    connection.Execute("INSERT INTO Employee(EmployeeId, EmployeeName, Salary, CompanyId, " +
                        "DivisionId, DepartmentId) VALUES " +
                        "(@EmployeeId, @EmployeeName, @Salary, @CompanyId, " +
                        "@DivisionId, @DepartmentId) ",
                        new
                        {
                            employee.EmployeeId,
                            employee.EmployeeName,
                            employee.Salary,
                            employee.CompanyId,
                            employee.DivisionId,
                            employee.DepartmentId,
                        }, transaction);
                    transaction.Commit();
                }
                catch (DbException de)
                {
                    Console.WriteLine($"An Error {de.Message}");
                    transaction.Rollback();
                }


                connection.Close();
            }
        }

        public void Update(Employee employee)
        {
            using (var connection = new SqlConnection(connString))
            {
                connection.Open();
                var transaction = connection.BeginTransaction();
                try
                {
                    connection.Execute("UPDATE Employee SET EmployeeName = @EmployeeName," +
                    " Salary = @Salary, CompanyId = @CompanyId," +
                    "DivisionId = @DivisionId, DepartmentId = @DepartmentId " +
                    "WHERE EmployeeId = @EmployeeId ", new
                    {
                        employee.EmployeeId,
                        employee.EmployeeName,
                        employee.Salary,
                        employee.CompanyId,
                        employee.DivisionId,
                        employee.DepartmentId,
                    }, transaction);

                    transaction.Commit();
                }
                catch (DbException dbe)
                {
                    Console.WriteLine($"An error Occured ! {dbe.Message}");
                }

                connection.Close();
            }
        }

        public void Delete(Guid Id)
        {
            using (var connection = new SqlConnection(connString))
            {
                connection.Open();
                var transaction = connection.BeginTransaction();
                try
                {
                    connection.Execute("DELETE FROM Employee WHERE EmployeeId = @Id",
                    new { Id }, transaction);
                    transaction.Commit();
                }
                catch (DbException de)
                {
                    Console.WriteLine(de.Message);
                    transaction.Rollback();

                }

                connection.Close();
            }
        }

    }
}
