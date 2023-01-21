using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13.Interfaces
{
    internal interface IConnection
    {
        string ConnectionString { get; }

        IDbConnection DatabaseConnection { get; }

        bool InTransaction { get; set; }

        void Close();

        void Open();
    }
}
