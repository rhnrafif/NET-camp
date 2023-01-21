using System.Xml;
using System.Data.SqlClient;

namespace Day13.SqlServices
{
    public static class SqlExtensions
    {
        public static XmlReader ExecuteSafeXmlReader(this SqlCommand cmd)
        {
            return new SqlXmlReader(cmd);
        }
    }
}
