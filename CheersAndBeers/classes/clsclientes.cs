using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CheersAndBeers.classes
{
    public class clsclientes
    {
        connection cn = new connection();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leerfilas;
        public DataTable Listarpaises()
        {
            DataTable tabla = new DataTable();
            comando.Connection = cn.abrirconexion();
            comando.CommandText = "listarpaises";
            comando.CommandType = CommandType.StoredProcedure;
            leerfilas = comando.ExecuteReader();
            tabla.Load(leerfilas);
            leerfilas.Close();
            cn.cerrarconexion();
            return tabla;

        }

        public DataTable Listarestados()
        {
            DataTable tabla = new DataTable();
            comando.Connection = cn.abrirconexion();
            comando.CommandText = "listarestados";
            comando.CommandType = CommandType.StoredProcedure;
            leerfilas = comando.ExecuteReader();
            tabla.Load(leerfilas);
            leerfilas.Close();
            cn.cerrarconexion();
            return tabla;

        }
        public DataTable Listarmunicipios()
        {
            DataTable tabla = new DataTable();
            comando.Connection = cn.abrirconexion();
            comando.CommandText = "listarmunicipios";
            comando.CommandType = CommandType.StoredProcedure;
            leerfilas = comando.ExecuteReader();
            tabla.Load(leerfilas);
            leerfilas.Close();
            cn.cerrarconexion();
            return tabla;

        }

        public void insertarcliente(int id_factura, string nombre_c, string ap_pat_c, string ap_mat_c, string telefono_c, string correo_c,
                                      int id_pais, int id_estado, int id_municipio)
        {
            comando.Connection = cn.abrirconexion();
            comando.CommandText = "insertarcliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_factura", id_factura);
            comando.Parameters.AddWithValue("@nombre_c", nombre_c);
            comando.Parameters.AddWithValue("@ap_pat_c", ap_pat_c);
            comando.Parameters.AddWithValue("@ap_mat_c", ap_mat_c);
            comando.Parameters.AddWithValue("@telefono_c", telefono_c);
            comando.Parameters.AddWithValue("@correo_c", correo_c);
            comando.Parameters.AddWithValue("@id_pais", id_pais);
            comando.Parameters.AddWithValue("@id_estado", id_estado);
            comando.Parameters.AddWithValue("@id_municipio", id_municipio);
            //comando.Parameters.AddWithValue("@fecha_nac_emp", fecha_nac_emp);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public DataTable Listarempleados()
        {
            DataTable tabla = new DataTable();
            comando.Connection = cn.abrirconexion();
            comando.CommandText = "insertarcliente";
            comando.CommandType = CommandType.StoredProcedure;
            leerfilas = comando.ExecuteReader();
            tabla.Load(leerfilas);
            leerfilas.Close();
            cn.cerrarconexion();
            return tabla;

        }

        public DataTable MostrarEmpleados()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_MOSTRARTABLACLIENTES", cn.abrirconexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
    
}
