using CheersAndBeers.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheersAndBeers
{
    public partial class Form5 : Form
    {
        connection cn = new connection();
        SqlCommand comando = new SqlCommand();

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            


            int numId = int.Parse(txtMat.Text);

            SqlCommand comando = new SqlCommand("select * from dbo.empleado where id_empleado = " + numId, cn.abrirconexion());


            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                txtnombre.Text = registro["nombre_emp"].ToString();
                txtappat.Text = registro["ap_pat_emp"].ToString();
                txtapmat.Text = registro["ap_mat_emp"].ToString();
                txttelefono.Text = registro["telefono_emp"].ToString();
                txtcorreo.Text = registro["correo_emp"].ToString();
                txtEstado.Text = registro["id_estado"].ToString();
                txtPais.Text = registro["id_pais"].ToString();
                txtMuni.Text = registro["id_municipio"].ToString();
            }
        }
    }
}
