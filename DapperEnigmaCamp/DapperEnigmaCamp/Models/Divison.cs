using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperEnigmaCamp.Models
{
    public class Divison
    {
        public Guid DivisionId { get; set; }
        public string DivisionName { get; set; }
        public Guid CompanyId { get; set; }
    }
}
