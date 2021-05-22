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
        clsempleados objEmpleados = new clsempleados();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listarpais();
            listarestado();
            listarmunicipio();
        }

        private void listarpais()
        {
            clsempleados objEmp = new clsempleados();
            cmbpais.DataSource = objEmp.Listarpaises();
            cmbpais.DisplayMember = ("nombrepais");
            cmbpais.ValueMember = ("id_pais");
        }

        private void listarestado()
        {
            clsempleados objEm = new clsempleados();
            cmbestado.DataSource = objEm.Listarestados();
            cmbestado.DisplayMember = ("nombreestado");
            cmbestado.ValueMember = ("id_estado");
        }

        private void listarmunicipio()
        {
            clsempleados objEmple = new clsempleados();
            cmbmunicipio.DataSource = objEmple.Listarmunicipios();
            cmbmunicipio.DisplayMember = ("nombremunicipio");
            cmbmunicipio.ValueMember = ("id_municipio");
        }

        private void guna2HtmlLabel1_Click_1(object sender, EventArgs e)
        {

        }


        private void guna2HtmlLabel9_Click(object sender, EventArgs e)
        {

        }

        private void cmbpais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            objEmpleados.insertarempleados(txtnombre.Text, txtappat.Text, txtapmat.Text, txttelefono.Text, txtcorreo.Text, 
                Convert.ToInt32(cmbpais.SelectedValue),Convert.ToInt32(cmbestado.SelectedValue),Convert.ToInt32(cmbmunicipio.SelectedValue));
            MessageBox.Show("Empleado agregado");
        }
    }
}
