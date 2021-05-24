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
    public partial class Form7 : Form
    {
        connection cn = new connection();
        SqlCommand comando = new SqlCommand();
        clsclientes objEmpleados = new clsclientes();
        public Form7()
        {
            InitializeComponent();
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            //listarpais();
            //listarestado();
            //listarmunicipio();
            Listarempleados();
        }
        private void Listarempleados()
        {
            clsclientes objEmp = new clsclientes();
            guna2DataGridView1.DataSource = objEmp.Listarempleados();
        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clsclientes objEmp = new clsclientes();
            guna2DataGridView1.DataSource = objEmp.Listarempleados();
        }
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            int numId = int.Parse(txtIdSearch.Text);
            string nombreEmp = txtnombre.Text;
            string apPatEmp = txtappat.Text;
            string apMatEmp = txtapmat.Text;
            string telefonoEmp = txttelefono.Text;
            string correoEmp = txtcorreo.Text;
            string EstadoEmp = txtEstado.Text;
            string PaisEmp = txtPais.Text;
            string MunicipioEmp = txtMuni.Text;

            string cadena = "update dbo.empleado set nombre_emp='" + nombreEmp + "',ap_pat_emp='" + apPatEmp + "',ap_mat_emp='" + apMatEmp + "',telefono_emp=" + telefonoEmp + ",correo_emp='" + correoEmp + "',id_pais=" + PaisEmp + ",id_estado=" + EstadoEmp + ",id_municipio=" + MunicipioEmp + "where id_empleado=" + numId;
            SqlCommand comando = new SqlCommand(cadena, cn.abrirconexion());

            int cant;

            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se modificaron los datos del empleado");
                txtnombre.Text = "";
                txtappat.Text = "";
                txtapmat.Text = "";
                txttelefono.Text = "";
                txtcorreo.Text = "";
                txtEstado.Text = "";
                txtPais.Text = "";
                txtMuni.Text = "";
            }
            else
                MessageBox.Show("No existe el empleado con dicha ID");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int numId = int.Parse(txtIdSearch.Text);

            SqlCommand comando = new SqlCommand("select * from dbo.empleado where id_empleado = " + numId, cn.abrirconexion());


            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                txtnombre.Text = registro["nombre_emp"].ToString();
                txtappat.Text = registro["ap_pat_emp"].ToString();
                txtapmat.Text = registro["ap_mat_emp"].ToString();
                txttelefono.Text = registro["telefono_emp"].ToString();
                txtcorreo.Text = registro["correo_emp"].ToString();
                txtEstado.Text = registro["id_estado"].ToString();
                txtPais.Text = registro["id_pais"].ToString();
                txtMuni.Text = registro["id_municipio"].ToString();
            }
        }
    }
}
