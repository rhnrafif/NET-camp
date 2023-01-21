using DapperEnigmaCamp.Aplications.Divisions;
using DapperEnigmaCamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperEnigmaCamp.Views.Divisions
{
    public class CreateDivisionView
    {
        private readonly IDivisionAppService _divAppService;
        public CreateDivisionView(IDivisionAppService divAppService)
        {
            _divAppService = divAppService;
        }

        public void DisplayView()
        {
            Console.Clear();
            Console.WriteLine("Create Division");
            Console.WriteLine("------------------------");

            
            Console.WriteLine("Division Name :");
            var divName = Console.ReadLine();
            Console.WriteLine("CompanyId :");
            var comId = Console.ReadLine();

            var division = new Divison();
            var guid = Guid.NewGuid();
            division.DivisionId = guid;
            division.DivisionName = divName;
            division.CompanyId = Guid.Parse(comId);

            _divAppService.Insert(division);
        }
    }
}
