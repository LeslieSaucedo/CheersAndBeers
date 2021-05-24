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
    public partial class Form10 : Form
    {
        connection cn = new connection();
        SqlCommand comando = new SqlCommand();
        clproductos objProductos = new clproductos();
        public Form10()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtapmat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            int precio = int.Parse(txtPrecio.Text);
            objProductos.insertarproductos(txtID.Text, txtNombreProd.Text, txtTipoProd.Text, txtPrecio.Text);
            MessageBox.Show("Producto agregado");
        }
    }
}
