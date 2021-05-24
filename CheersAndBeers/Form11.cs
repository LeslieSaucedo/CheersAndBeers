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
    public partial class Form11 : Form
    {
        connection cn = new connection();
        SqlCommand comando = new SqlCommand();
        public Form11()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            int numId = int.Parse(txtID.Text);
            string nombrePro = txtNombrePro.Text;
            string tipoPro = txtTipoPro.Text;
            string precioPro = txtPrecio.Text;
            

            string cadena = "update dbo.productos set id_producto=" + numId + ",nombre_producto='" + nombrePro + "',tipo_producto='" + tipoPro + "',precio_producto=" + precioPro + "where id_producto=" + numId;
            SqlCommand comando = new SqlCommand(cadena, cn.abrirconexion());

            int cant;

            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se modificaron los datos del producto");
                txtID.Text = "";
                txtNombrePro.Text = "";
                txtTipoPro.Text = "";
                txtPrecio.Text = "";
            }
            else
                MessageBox.Show("No existe el producto con dicha ID");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int numId = int.Parse(txtIdSearch.Text);

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
    }
}
