using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace superShopManagementSystem
{
    internal class Connection
    {

        public SqlConnection thisConnection = new SqlConnection(@"Data Source=DESKTOP-R0B9L4A\SQLEXPRESS;Initial Catalog=superShopManagement;Integrated Security=True");

    }
}
