namespace SistemaEncomienda
{
    partial class frmModificarCliente
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
            this.dgvModificar = new System.Windows.Forms.DataGridView();
            this.tbEmailcliente = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbDireccionCliente = new System.Windows.Forms.TextBox();
            this.tbDniCliente = new System.Windows.Forms.TextBox();
            this.tbApellidoCliente = new System.Windows.Forms.TextBox();
            this.tbNomCliente = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCel = new System.Windows.Forms.Label();
            this.lblDirec = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblAgApellido = new System.Windows.Forms.Label();
            this.lblAgNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvModificar
            // 
            this.dgvModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModificar.Location = new System.Drawing.Point(408, 105);
            this.dgvModificar.Name = "dgvModificar";
            this.dgvModificar.Size = new System.Drawing.Size(531, 240);
            this.dgvModificar.TabIndex = 0;
            this.dgvModificar.Click += new System.EventHandler(this.dgvModificar_Click);
            // 
            // tbEmailcliente
            // 
            this.tbEmailcliente.Location = new System.Drawing.Point(155, 318);
            this.tbEmailcliente.Multiline = true;
            this.tbEmailcliente.Name = "tbEmailcliente";
            this.tbEmailcliente.Size = new System.Drawing.Size(198, 27);
            this.tbEmailcliente.TabIndex = 36;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(155, 277);
            this.tbTelefono.Multiline = true;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(158, 27);
            this.tbTelefono.TabIndex = 35;
            // 
            // tbDireccionCliente
            // 
            this.tbDireccionCliente.Location = new System.Drawing.Point(155, 235);
            this.tbDireccionCliente.Multiline = true;
            this.tbDireccionCliente.Name = "tbDireccionCliente";
            this.tbDireccionCliente.Size = new System.Drawing.Size(158, 27);
            this.tbDireccionCliente.TabIndex = 34;
            // 
            // tbDniCliente
            // 
            this.tbDniCliente.Enabled = false;
            this.tbDniCliente.Location = new System.Drawing.Point(155, 193);
            this.tbDniCliente.MaxLength = 8;
            this.tbDniCliente.Multiline = true;
            this.tbDniCliente.Name = "tbDniCliente";
            this.tbDniCliente.Size = new System.Drawing.Size(158, 27);
            this.tbDniCliente.TabIndex = 33;
            // 
            // tbApellidoCliente
            // 
            this.tbApellidoCliente.Enabled = false;
            this.tbApellidoCliente.Location = new System.Drawing.Point(155, 150);
            this.tbApellidoCliente.Multiline = true;
            this.tbApellidoCliente.Name = "tbApellidoCliente";
            this.tbApellidoCliente.Size = new System.Drawing.Size(158, 27);
            this.tbApellidoCliente.TabIndex = 32;
            // 
            // tbNomCliente
            // 
            this.tbNomCliente.Enabled = false;
            this.tbNomCliente.Location = new System.Drawing.Point(155, 105);
            this.tbNomCliente.Multiline = true;
            this.tbNomCliente.Name = "tbNomCliente";
            this.tbNomCliente.Size = new System.Drawing.Size(158, 27);
            this.tbNomCliente.TabIndex = 31;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Black;
            this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmail.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmail.Location = new System.Drawing.Point(26, 318);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(85, 27);
            this.lblEmail.TabIndex = 30;
            this.lblEmail.Text = "E-mail";
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.BackColor = System.Drawing.Color.Black;
            this.lblCel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCel.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCel.Location = new System.Drawing.Point(26, 277);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(108, 27);
            this.lblCel.TabIndex = 29;
            this.lblCel.Text = "Telefono";
            // 
            // lblDirec
            // 
            this.lblDirec.AutoSize = true;
            this.lblDirec.BackColor = System.Drawing.Color.Black;
            this.lblDirec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDirec.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirec.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDirec.Location = new System.Drawing.Point(26, 235);
            this.lblDirec.Name = "lblDirec";
            this.lblDirec.Size = new System.Drawing.Size(119, 27);
            this.lblDirec.TabIndex = 28;
            this.lblDirec.Text = "Direccion";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Black;
            this.lblDni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDni.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDni.Location = new System.Drawing.Point(26, 193);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(54, 27);
            this.lblDni.TabIndex = 27;
            this.lblDni.Text = "Dni";
            // 
            // lblAgApellido
            // 
            this.lblAgApellido.AutoSize = true;
            this.lblAgApellido.BackColor = System.Drawing.Color.Black;
            this.lblAgApellido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAgApellido.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgApellido.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAgApellido.Location = new System.Drawing.Point(26, 150);
            this.lblAgApellido.Name = "lblAgApellido";
            this.lblAgApellido.Size = new System.Drawing.Size(104, 27);
            this.lblAgApellido.TabIndex = 26;
            this.lblAgApellido.Text = "Apellido";
            // 
            // lblAgNombre
            // 
            this.lblAgNombre.AutoSize = true;
            this.lblAgNombre.BackColor = System.Drawing.Color.Black;
            this.lblAgNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAgNombre.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAgNombre.Location = new System.Drawing.Point(26, 105);
            this.lblAgNombre.Name = "lblAgNombre";
            this.lblAgNombre.Size = new System.Drawing.Size(103, 27);
            this.lblAgNombre.TabIndex = 25;
            this.lblAgNombre.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(362, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 31);
            this.label3.TabIndex = 37;
            this.label3.Text = "Modificar Cliente";
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarCliente.BackgroundImage = global::SistemaEncomienda.Properties.Resources.Material_Icons_e55a_1__256;
            this.btnModificarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModificarCliente.FlatAppearance.BorderSize = 0;
            this.btnModificarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModificarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCliente.Location = new System.Drawing.Point(155, 360);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(105, 88);
            this.btnModificarCliente.TabIndex = 38;
            this.btnModificarCliente.UseVisualStyleBackColor = false;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackgroundImage = global::SistemaEncomienda.Properties.Resources.Iconic_2718_0__256;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(266, 360);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 88);
            this.btnEliminar.TabIndex = 39;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaEncomienda.Properties.Resources._638383__wallpaper_mambots_black_web_p;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 460);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEmailcliente);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbDireccionCliente);
            this.Controls.Add(this.tbDniCliente);
            this.Controls.Add(this.tbApellidoCliente);
            this.Controls.Add(this.tbNomCliente);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCel);
            this.Controls.Add(this.lblDirec);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblAgApellido);
            this.Controls.Add(this.lblAgNombre);
            this.Controls.Add(this.dgvModificar);
            this.Name = "frmModificarCliente";
            this.Load += new System.EventHandler(this.frmModificarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvModificar;
        private System.Windows.Forms.TextBox tbEmailcliente;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbDireccionCliente;
        private System.Windows.Forms.TextBox tbDniCliente;
        private System.Windows.Forms.TextBox tbApellidoCliente;
        private System.Windows.Forms.TextBox tbNomCliente;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.Label lblDirec;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblAgApellido;
        private System.Windows.Forms.Label lblAgNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnEliminar;
    }
}