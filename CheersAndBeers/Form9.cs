using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheersAndBeers.classes;
using System.Data.SqlClient;

namespace CheersAndBeers
{
    public partial class Form9 : Form
    {
        connection cn = new connection();
        SqlCommand comando = new SqlCommand();
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtMat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            int numId = int.Parse(txtMat.Text);

            SqlCommand comando = new SqlCommand("select * from dbo.clientes where id_cliente = " + numId, cn.abrirconexion());


            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                txtnombre.Text = registro["nombre_c"].ToString();
                txtappat.Text = registro["ap_pat_c"].ToString();
                txtapmat.Text = registro["ap_mat_c"].ToString();
                txttelefono.Text = registro["telefono_c"].ToString();
                txtcorreo.Text = registro["correo_c"].ToString();
                txtEstado.Text = registro["id_estado"].ToString();
                txtPais.Text = registro["id_pais"].ToString();
                txtMuni.Text = registro["id_municipio"].ToString();
            }
        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }
    }
}
