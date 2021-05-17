using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheersAndBeers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelEmpleadosSubmenu.Visible = false;
            panelClientesSubmenu.Visible = false;
            panelProductosSubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelEmpleadosSubmenu.Visible == true)
                panelEmpleadosSubmenu.Visible = false;
            if (panelClientesSubmenu.Visible == true)
                panelClientesSubmenu.Visible = false;
            if (panelProductosSubmenu.Visible == true)
                panelProductosSubmenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            openChildForm(new Form4());
            hideSubMenu();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            hideSubMenu();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            hideSubMenu();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            openChildForm(new Form5());
            hideSubMenu();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEmpleadosSubmenu);
        }

        private void panelSidemenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            openChildForm(new Form14());
            hideSubMenu();
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelClientesSubmenu);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new Form6());
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new Form7());
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new Form8());
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Form9());
            hideSubMenu();
        }

        private void buttonProductos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProductosSubmenu);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            openChildForm(new Form10());
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            openChildForm(new Form11());
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openChildForm(new Form12());
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new Form13());
            hideSubMenu();
        }

        private void buttonFacturacion_Click(object sender, EventArgs e)
        {
            openChildForm(new Form15());
            hideSubMenu();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


    }
}
