using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    class DB_Access
    {
        SqlConnection conn;

        public DB_Access()
        {
            conn = DB_Connection.GetConnection();

        }
    }
}
