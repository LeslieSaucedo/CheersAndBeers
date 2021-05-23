using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CheersAndBeers.classes;

namespace CheersAndBeers
{
    public partial class Form3 : Form
    {
        //clsempleados objEmpleados = new clsempleados();
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            //listarpais();
            //listarestado();
            //listarmunicipio();
            Listarempleados();
        }

       private void Listarempleados()
        {
            clsempleados objEmp = new clsempleados();
            guna2DataGridView1.DataSource = objEmp.Listarempleados();
        }
        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clsempleados objEmp = new clsempleados();
            guna2DataGridView1.DataSource = objEmp.Listarempleados();
        }
    }
}
