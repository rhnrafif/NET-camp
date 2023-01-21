using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day13.Interfaces
{
    public interface ICommands
    {
        int ExecuteNonQuery(string commandText, params DbParameter[] parameters);

        int ExecuteNonQuery(out DbCommand cmd, string commandText, params DbParameter[] parameters);

        object ExecuteScalar(string commandText, params DbParameter[] parameters);

        object ExecuteScalar(out DbCommand cmd, string commandText, params DbParameter[] parameters);

        DbDataReader ExecuteReader(string commandText, params DbParameter[] parameters);

        DataTable ExecuteDataTable(string commandText, params DbParameter[] parameters);

        DataTable ExecuteDataTable(out DbCommand cmd, string commandText, params DbParameter[] parameters);


        DataSet ExecuteDataSet(string commandText, params DbParameter[] parameters);


        DataSet ExecuteDataSet(out DbCommand cmd, string commandText, params DbParameter[] parameters);


        XmlReader ExecuteXmlReader(string commandText, params DbParameter[] parameters);

        XmlReader ExecuteXmlReader(out DbCommand cmd, string commandText, params DbParameter[] parameters);
    }
}
