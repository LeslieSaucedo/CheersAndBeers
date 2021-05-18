using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CheersAndBeers.classes
{
    public class cheersandbeers
    {

        connection cn = new connection();

        public DataTable MostrarPlacas()
        {
            SqlDataAdapter da = new SqlDataAdapter("PENDIENTE", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
