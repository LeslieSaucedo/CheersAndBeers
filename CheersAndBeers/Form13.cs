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
    public partial class Form13 : Form
    {
        connection cn = new connection();
        SqlCommand comando = new SqlCommand();
        public Form13()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            int numId = int.Parse(txtMat.Text);

            SqlCommand comando = new SqlCommand("select * from dbo.productos where id_producto = " + numId, cn.abrirconexion());


            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                txtID.Text = registro["id_producto"].ToString();
                txtNombrePro.Text = registro["nombre_producto"].ToString();
                txtTipoPro.Text = registro["tipo_producto"].ToString();
                txtPrecio.Text = registro["precio_producto"].ToString();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
