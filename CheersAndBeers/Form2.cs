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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            connection cn = new connection();
           

            cn.LeerCadena();
            
            int idMesero = int.Parse(txtMesId.Text);
            string nombreMesero = txtNombre.Text;
            string ApMatMesero = txtApMat.Text;
            string ApPatMesero = txtApPat.Text;
            int EstadoM = int.Parse(txtEstado.Text);
            int MunicipioM = int.Parse(txtMunicipio.Text);
            int turnoM = int.Parse(txtTurno.Text);
            string telefono = txtTelefono.Text;
            string correoM = txtCorreo.Text;
            DateTime fecha = DateNacimiento.Value.Date;


            SqlCommand query = new SqlCommand("INSERT INTO dbo.meseros (nombre_m, correo, ape_mat_m, ape_pat_m, mesero_id, estado_id, municipio_id, fecha_nac_m, turno_m, telefono ) VALUES ('" + nombreMesero + "','" + correoM + "','" + ApMatMesero + "','" + ApPatMesero + "','" + idMesero + "','" + EstadoM + "','" + MunicipioM + "','" + fecha + "','" + turnoM + "','" + telefono + "')", cn.LeerCadena());

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

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
