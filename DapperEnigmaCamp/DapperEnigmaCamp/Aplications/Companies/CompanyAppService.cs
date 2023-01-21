using Dapper;
using DapperEnigmaCamp.Aplications.Companies.Dto;
using DapperEnigmaCamp.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperEnigmaCamp.Aplications.Companies
{
    public class CompanyAppService : ICompanyAppService
    {
        private readonly string connString = @"Server=RHNRAFIF\SQLEXPRESS;Database=ShipDB;Trusted_Connection=True;";
        public void Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        public List<CompanyDto> GetAllCompany()
        {
            throw new NotImplementedException();
        }

        public void Insert(Company company)
        {
            using(var connection = new SqlConnection(connString))
            {
                connection.Open();
                var transaction = connection.BeginTransaction();
                try
                {
                    connection.Execute("INSERT INTO Company (CompanyId, CompanyName) " +
                        "VALUES (@CompanyId, @CompanyName)",
                        new
                        {
                            CompanyId = company.CompanyId,
                            CompanyName = company.CompanyName,
                        }, transaction);
                    transaction.Commit();

                }
                catch (DbException de)
                {
                    Console.WriteLine(de.Message);
                    transaction.Rollback();
                }
            }
        }

        public void Update(Company company)
        {
            throw new NotImplementedException();
        }
    }
}
