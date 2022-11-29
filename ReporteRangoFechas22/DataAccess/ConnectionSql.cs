using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class ConnectionSql
    {
        protected SqlConnection getConnection()
        {
            return new SqlConnection("Data Source=(local);Initial Catalog=Bike_Store;Integrated Security=True");
        }
    }
}
