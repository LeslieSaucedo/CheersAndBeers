using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheersAndBeers.classes
{
    class clproductos
    {
        connection cn = new connection();
        SqlCommand comando = new SqlCommand();
        //SqlDataReader leerfilas;

        public void insertarproductos(string idProducto, string nombreProducto, string TipoProducto, string PrecioProducto)
        {
            comando.Connection = cn.abrirconexion();
            comando.CommandText = "insertarproductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_producto", idProducto);
            comando.Parameters.AddWithValue("@nombre_producto", nombreProducto);
            comando.Parameters.AddWithValue("@tipo_producto", TipoProducto);
            comando.Parameters.AddWithValue("@precio_producto", PrecioProducto);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

       
    }
}
