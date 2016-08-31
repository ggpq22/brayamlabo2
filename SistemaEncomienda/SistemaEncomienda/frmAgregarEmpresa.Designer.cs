namespace SistemaEncomienda
{
    partial class frmAgregarEmpresa
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
            this.dgvAgregarCliente = new System.Windows.Forms.DataGridView();
            this.tbDireccionEmpresa = new System.Windows.Forms.TextBox();
            this.tbCiudad = new System.Windows.Forms.TextBox();
            this.tbNomEmpresa = new System.Windows.Forms.TextBox();
            this.lblCel = new System.Windows.Forms.Label();
            this.lblDirec = new System.Windows.Forms.Label();
            this.lblAgApellido = new System.Windows.Forms.Label();
            this.lblAgNombre = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAgregarCliente
            // 
            this.dgvAgregarCliente.AllowUserToAddRows = false;
            this.dgvAgregarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregarCliente.Location = new System.Drawing.Point(365, 89);
            this.dgvAgregarCliente.MultiSelect = false;
            this.dgvAgregarCliente.Name = "dgvAgregarCliente";
            this.dgvAgregarCliente.ReadOnly = true;
            this.dgvAgregarCliente.Size = new System.Drawing.Size(432, 188);
            this.dgvAgregarCliente.TabIndex = 39;
            // 
            // tbDireccionEmpresa
            // 
            this.tbDireccionEmpresa.Location = new System.Drawing.Point(214, 190);
            this.tbDireccionEmpresa.Multiline = true;
            this.tbDireccionEmpresa.Name = "tbDireccionEmpresa";
            this.tbDireccionEmpresa.Size = new System.Drawing.Size(105, 27);
            this.tbDireccionEmpresa.TabIndex = 36;
            // 
            // tbCiudad
            // 
            this.tbCiudad.Location = new System.Drawing.Point(214, 134);
            this.tbCiudad.Multiline = true;
            this.tbCiudad.Name = "tbCiudad";
            this.tbCiudad.Size = new System.Drawing.Size(105, 27);
            this.tbCiudad.TabIndex = 34;
            // 
            // tbNomEmpresa
            // 
            this.tbNomEmpresa.Location = new System.Drawing.Point(214, 89);
            this.tbNomEmpresa.Multiline = true;
            this.tbNomEmpresa.Name = "tbNomEmpresa";
            this.tbNomEmpresa.Size = new System.Drawing.Size(105, 27);
            this.tbNomEmpresa.TabIndex = 33;
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.BackColor = System.Drawing.Color.Black;
            this.lblCel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCel.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCel.Location = new System.Drawing.Point(58, 242);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(108, 27);
            this.lblCel.TabIndex = 31;
            this.lblCel.Text = "Telefono";
            // 
            // lblDirec
            // 
            this.lblDirec.AutoSize = true;
            this.lblDirec.BackColor = System.Drawing.Color.Black;
            this.lblDirec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDirec.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirec.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDirec.Location = new System.Drawing.Point(58, 190);
            this.lblDirec.Name = "lblDirec";
            this.lblDirec.Size = new System.Drawing.Size(119, 27);
            this.lblDirec.TabIndex = 30;
            this.lblDirec.Text = "Direccion";
            // 
            // lblAgApellido
            // 
            this.lblAgApellido.AutoSize = true;
            this.lblAgApellido.BackColor = System.Drawing.Color.Black;
            this.lblAgApellido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAgApellido.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgApellido.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAgApellido.Location = new System.Drawing.Point(58, 134);
            this.lblAgApellido.Name = "lblAgApellido";
            this.lblAgApellido.Size = new System.Drawing.Size(91, 27);
            this.lblAgApellido.TabIndex = 28;
            this.lblAgApellido.Text = "Ciudad";
            // 
            // lblAgNombre
            // 
            this.lblAgNombre.AutoSize = true;
            this.lblAgNombre.BackColor = System.Drawing.Color.Black;
            this.lblAgNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAgNombre.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAgNombre.Location = new System.Drawing.Point(58, 89);
            this.lblAgNombre.Name = "lblAgNombre";
            this.lblAgNombre.Size = new System.Drawing.Size(103, 27);
            this.lblAgNombre.TabIndex = 27;
            this.lblAgNombre.Text = "Nombre";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(214, 242);
            this.tbTelefono.Multiline = true;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(105, 27);
            this.tbTelefono.TabIndex = 37;
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.Transparent;
            this.btnGrabar.BackgroundImage = global::SistemaEncomienda.Properties.Resources.Material_Icons_e161_0__2561;
            this.btnGrabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGrabar.FlatAppearance.BorderSize = 0;
            this.btnGrabar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGrabar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Location = new System.Drawing.Point(214, 305);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(105, 101);
            this.btnGrabar.TabIndex = 40;
            this.btnGrabar.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(365, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 47);
            this.button2.TabIndex = 41;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmAgregarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaEncomienda.Properties.Resources.AA1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 418);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.dgvAgregarCliente);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbDireccionEmpresa);
            this.Controls.Add(this.tbCiudad);
            this.Controls.Add(this.tbNomEmpresa);
            this.Controls.Add(this.lblCel);
            this.Controls.Add(this.lblDirec);
            this.Controls.Add(this.lblAgApellido);
            this.Controls.Add(this.lblAgNombre);
            this.Name = "frmAgregarEmpresa";
            this.Load += new System.EventHandler(this.frmAgregarEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAgregarCliente;
        private System.Windows.Forms.TextBox tbDireccionEmpresa;
        private System.Windows.Forms.TextBox tbCiudad;
        private System.Windows.Forms.TextBox tbNomEmpresa;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.Label lblDirec;
        private System.Windows.Forms.Label lblAgApellido;
        private System.Windows.Forms.Label lblAgNombre;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button button2;
    }
}