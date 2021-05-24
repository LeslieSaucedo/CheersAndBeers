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
    public partial class Form12 : Form
    {
        connection cn = new connection();
        SqlCommand comando = new SqlCommand();
        public Form12()
        {
            InitializeComponent();
        }

        private void btnElminar_Click(object sender, EventArgs e)
        {
            connection cn = new connection();
            cn.abrirconexion();

          


            int id = 0;
            try
            {

                id = int.Parse(txtActualId.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debes elegir un ID");
            }

            id = int.Parse(txtActualId.Text);

            int newId;

            newId = id;

            SqlCommand query = new SqlCommand("delete dbo.productos where id_producto = " + id, cn.abrirconexion());
            int resultado = query.ExecuteNonQuery();

            if (resultado > 0)
            {

                MessageBox.Show("Se guardo la informacion existosamente.");

            }
            else
            {
                MessageBox.Show("No se pudieron guardar los datos exitosamente.");
            }
        }
    }
}
