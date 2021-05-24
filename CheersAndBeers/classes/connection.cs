using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace CheersAndBeers.classes
{
    public class connection
    {
        
        private SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["edgardo"].ConnectionString); // Cambiar "edgardo" por su nombre

        public SqlConnection abrirconexion()
        {
           if (cn.State == ConnectionState.Closed)
           
                cn.Open();
           return cn;
                
        }
            
        public SqlConnection cerrarconexion()
        {
            if (cn.State == ConnectionState.Open)
              cn.Close();
            return cn;
            
        }
          
        
    }
}
