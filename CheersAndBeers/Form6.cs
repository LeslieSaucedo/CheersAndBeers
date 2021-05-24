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
    public partial class Form6 : Form
    {
        clsclientes objEmpleados = new clsclientes();
        public Form6()
        {
            InitializeComponent();
        }
        private void Form6_Load(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnagregar_Click(object sender, EventArgs e)
        {
            objEmpleados.insertarcliente(txtnombre.Text, txtappat.Text, txtapmat.Text, txttelefono.Text, txtcorreo.Text,
               Convert.ToInt32(cmbpais.SelectedValue), Convert.ToInt32(cmbestado.SelectedValue), Convert.ToInt32(cmbmunicipio.SelectedValue));
            MessageBox.Show("Cliente agregado");
        }
    }
}