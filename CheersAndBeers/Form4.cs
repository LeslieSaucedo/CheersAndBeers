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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        connection cn = new connection();
        SqlCommand comando = new SqlCommand();

        private void Form4_Load(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = emp.MostrarEmpleados();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        clsempleados emp = new clsempleados();

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            
            connection cn = new connection();
            cn.abrirconexion();

            //DataGridViewCellEventArgs asd = new DataGridViewCellEventArgs(1, 1);

            //txtActualId.Text = dgvEmpleados.CurrentCell.Value.ToString();
            

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

            SqlCommand query = new SqlCommand("delete dbo.empleado where id_empleado = " + id, cn.abrirconexion());
            int resultado = query.ExecuteNonQuery();

            if (resultado > 0)
            {

                MessageBox.Show("Se guardo la informacion existosamente.");

            }
            else
            {
                MessageBox.Show("No se pudieron guardar los datos exitosamente.");
            }

            dgvEmpleados.DataSource = emp.Listarempleados();
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
