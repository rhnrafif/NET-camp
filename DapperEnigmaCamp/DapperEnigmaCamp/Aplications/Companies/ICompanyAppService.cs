using DapperEnigmaCamp.Aplications.Companies.Dto;
using DapperEnigmaCamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperEnigmaCamp.Aplications.Companies
{
    public interface ICompanyAppService
    {
        void Insert(Company company);
        void Delete(Guid Id);
        void Update(Company company);
        List<CompanyDto> GetAllCompany();

    }
}
