using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace library_management_system
{
    internal class Connection
    {
        public SqlConnection thisConnection = new SqlConnection(@"Data Source=DESKTOP-R0B9L4A\SQLEXPRESS;Initial Catalog=libraryManagemnet;Integrated Security=True");
    }

}
