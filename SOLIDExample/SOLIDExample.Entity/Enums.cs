using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExample.Entity
{
    public enum OrderType
    {
        Company = 1,
        Personal = 2,
    }

    public enum OrderStatus
    {
        Created = 1,
        Paid = 2,
        Ship = 3,
    }
}
