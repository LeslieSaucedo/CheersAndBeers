using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CheersAndBeers.classes
{
    public class clsempleados
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
        
        public void insertarempleados( string nombre_emp, string ap_pat_emp, string ap_mat_emp,string telefono_emp, string correo_emp, 
                                      int id_pais, int id_estado, int id_municipio) {
            comando.Connection = cn.abrirconexion();
            comando.CommandText = "insertarempleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre_emp", nombre_emp);
            comando.Parameters.AddWithValue("@ap_pat_emp", ap_pat_emp);
            comando.Parameters.AddWithValue("@ap_mat_emp", ap_mat_emp);
            comando.Parameters.AddWithValue("@telefono_emp", telefono_emp);
            comando.Parameters.AddWithValue("@correo_emp", correo_emp);
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
            comando.CommandText = "listarempleados";
            comando.CommandType = CommandType.StoredProcedure;
            leerfilas = comando.ExecuteReader();
            tabla.Load(leerfilas);
            leerfilas.Close();
            cn.cerrarconexion();
            return tabla;

        }

        public DataTable MostrarEmpleados()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_MOSTRARTABLAEMPLEADOS",cn.abrirconexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        
        
    }
}
