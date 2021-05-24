
namespace CheersAndBeers
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.btnElminar = new Guna.UI2.WinForms.Guna2Button();
            this.txtActualId = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.opcionmensje = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.opcionmensje.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvEmpleados);
            this.panel1.Controls.Add(this.btnElminar);
            this.panel1.Controls.Add(this.txtActualId);
            this.panel1.Controls.Add(this.guna2HtmlLabel3);
            this.panel1.Controls.Add(this.opcionmensje);
            this.panel1.Controls.Add(this.guna2HtmlLabel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 621);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(33, 216);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(695, 353);
            this.dgvEmpleados.TabIndex = 55;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            // 
            // btnElminar
            // 
            this.btnElminar.CheckedState.Parent = this.btnElminar;
            this.btnElminar.CustomImages.Parent = this.btnElminar;
            this.btnElminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnElminar.ForeColor = System.Drawing.Color.White;
            this.btnElminar.HoverState.Parent = this.btnElminar;
            this.btnElminar.Location = new System.Drawing.Point(111, 141);
            this.btnElminar.Name = "btnElminar";
            this.btnElminar.ShadowDecoration.Parent = this.btnElminar;
            this.btnElminar.Size = new System.Drawing.Size(160, 33);
            this.btnElminar.TabIndex = 54;
            this.btnElminar.Text = "Eliminar";
            this.btnElminar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtActualId
            // 
            this.txtActualId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtActualId.DefaultText = "";
            this.txtActualId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtActualId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtActualId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtActualId.DisabledState.Parent = this.txtActualId;
            this.txtActualId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtActualId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtActualId.FocusedState.Parent = this.txtActualId;
            this.txtActualId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtActualId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtActualId.HoverState.Parent = this.txtActualId;
            this.txtActualId.Location = new System.Drawing.Point(111, 108);
            this.txtActualId.Name = "txtActualId";
            this.txtActualId.PasswordChar = '\0';
            this.txtActualId.PlaceholderText = "";
            this.txtActualId.SelectedText = "";
            this.txtActualId.ShadowDecoration.Parent = this.txtActualId;
            this.txtActualId.Size = new System.Drawing.Size(232, 27);
            this.txtActualId.TabIndex = 53;
            this.txtActualId.TextChanged += new System.EventHandler(this.txtActualId_TextChanged);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(10, 111);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(98, 18);
            this.guna2HtmlLabel3.TabIndex = 52;
            this.guna2HtmlLabel3.Text = "Id de empleado";
            this.guna2HtmlLabel3.Click += new System.EventHandler(this.guna2HtmlLabel3_Click);
            // 
            // opcionmensje
            // 
            this.opcionmensje.BackColor = System.Drawing.SystemColors.GrayText;
            this.opcionmensje.Controls.Add(this.guna2HtmlLabel1);
            this.opcionmensje.Dock = System.Windows.Forms.DockStyle.Top;
            this.opcionmensje.Location = new System.Drawing.Point(0, 0);
            this.opcionmensje.Name = "opcionmensje";
            this.opcionmensje.ShadowDecoration.Parent = this.opcionmensje;
            this.opcionmensje.Size = new System.Drawing.Size(812, 90);
            this.opcionmensje.TabIndex = 24;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(44, 27);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(263, 35);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Eliminar empleado";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(394, 236);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = null;
            this.guna2HtmlLabel2.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 621);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.opcionmensje.ResumeLayout(false);
            this.opcionmensje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Panel opcionmensje;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnElminar;
        private Guna.UI2.WinForms.Guna2TextBox txtActualId;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private System.Windows.Forms.DataGridView dgvEmpleados;
    }
}