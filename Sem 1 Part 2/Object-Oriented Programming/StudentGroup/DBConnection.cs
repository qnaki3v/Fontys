using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroup
{
    public class DBConnection
    {
        public static SqlConnection CreateConnection()
        {
            return new SqlConnection("Server=mssqlstud.fhict.local;Database=dbi507399;User Id=dbi507399;Password=pi24pi24;");
        }
    }
}
