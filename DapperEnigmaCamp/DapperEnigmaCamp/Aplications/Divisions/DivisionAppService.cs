using Dapper;
using DapperEnigmaCamp.Aplications.Divisions.Dto;
using DapperEnigmaCamp.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperEnigmaCamp.Aplications.Divisions
{
    public class DivisionAppService : IDivisionAppService
    {
        private readonly string connString = @"Server=RHNRAFIF\SQLEXPRESS;Database=ShipDB;Trusted_Connection=True;";
        public void Delete(Divison divison)
        {
            throw new NotImplementedException();
        }

        public List<DivisionDto> GetAllDivision()
        {
            throw new NotImplementedException();
        }

        public void Insert(Divison divison)
        {
            using(var connection = new SqlConnection(connString))
            {
                connection.Open();
                var transaction = connection.BeginTransaction();
                try
                {
                    connection.Execute("INSERT INTO Division (DivisionId, DivisionName, CompanyId)" +
                        " VALUES (@DivisionId, @DivisionName, @CompanyId)", 
                        new {
                        divison.DivisionId,
                        divison.DivisionName,
                        divison.CompanyId
                        }, transaction);
                    transaction.Commit();

                }
                catch (DbException de)
                {
                    transaction.Rollback();
                    Console.WriteLine($"An Error {de.Message}");
                }
            }
        }

        public void Update(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
