using DapperEnigmaCamp.Aplications.Divisions.Dto;
using DapperEnigmaCamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperEnigmaCamp.Aplications.Divisions
{
    public interface IDivisionAppService
    {
        void Insert(Divison divison);
        void Update(Guid Id);
        void Delete(Divison divison);
        List<DivisionDto> GetAllDivision();
    }
}
