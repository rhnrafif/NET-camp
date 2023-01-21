using DapperEnigmaCamp.Aplications.Companies;
using DapperEnigmaCamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperEnigmaCamp.Views.Companies
{
    public class CreateCompanyView
    {
        private readonly ICompanyAppService _compAppService;
        public CreateCompanyView(ICompanyAppService compAppService)
        {
            _compAppService = compAppService;
        }
        public void DisplayView()
        {
            Console.Clear();
            Console.WriteLine("Create Company");
            Console.WriteLine("----------------------");

            Console.Write("Company Name : ");
            var companyName = Console.ReadLine();

            var company = new Company();

            Guid guid = Guid.NewGuid();
            company.CompanyName = companyName;
            company.CompanyId = guid;

            _compAppService.Insert(company);

        }
    }
}
