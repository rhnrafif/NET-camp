using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreEnigma.Database
{
    public class vw_StudentAddress
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
    }
}
