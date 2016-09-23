namespace SistemaEncomienda
{
    partial class frmAgregarCliente
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
            this.dgvAgregarCliente = new System.Windows.Forms.DataGridView();
            this.btnGrabarCliente = new System.Windows.Forms.Button();
            this.btnMostrarClientes = new System.Windows.Forms.Button();
            this.tbCiudadCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEmailcliente
            // 
            this.tbEmailcliente.Location = new System.Drawing.Point(154, 301);
            this.tbEmailcliente.Multiline = true;
            this.tbEmailcliente.Name = "tbEmailcliente";
            this.tbEmailcliente.Size = new System.Drawing.Size(198, 27);
            this.tbEmailcliente.TabIndex = 24;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(154, 260);
            this.tbTelefono.Multiline = true;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(158, 27);
            this.tbTelefono.TabIndex = 23;
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDniCliente_KeyPress);
            // 
            // tbDireccionCliente
            // 
            this.tbDireccionCliente.Location = new System.Drawing.Point(154, 218);
            this.tbDireccionCliente.Multiline = true;
            this.tbDireccionCliente.Name = "tbDireccionCliente";
            this.tbDireccionCliente.Size = new System.Drawing.Size(158, 27);
            this.tbDireccionCliente.TabIndex = 22;
            // 
            // tbDniCliente
            // 
            this.tbDniCliente.Location = new System.Drawing.Point(154, 176);
            this.tbDniCliente.MaxLength = 8;
            this.tbDniCliente.Multiline = true;
            this.tbDniCliente.Name = "tbDniCliente";
            this.tbDniCliente.Size = new System.Drawing.Size(158, 27);
            this.tbDniCliente.TabIndex = 21;
            this.tbDniCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDniCliente_KeyPress);
            // 
            // tbApellidoCliente
            // 
            this.tbApellidoCliente.Location = new System.Drawing.Point(154, 133);
            this.tbApellidoCliente.Multiline = true;
            this.tbApellidoCliente.Name = "tbApellidoCliente";
            this.tbApellidoCliente.Size = new System.Drawing.Size(158, 27);
            this.tbApellidoCliente.TabIndex = 20;
            this.tbApellidoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNomCliente_KeyPress);
            // 
            // tbNomCliente
            // 
            this.tbNomCliente.Location = new System.Drawing.Point(154, 88);
            this.tbNomCliente.Multiline = true;
            this.tbNomCliente.Name = "tbNomCliente";
            this.tbNomCliente.Size = new System.Drawing.Size(158, 27);
            this.tbNomCliente.TabIndex = 19;
            this.tbNomCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNomCliente_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Black;
            this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmail.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmail.Location = new System.Drawing.Point(25, 301);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(85, 27);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "E-mail";
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.BackColor = System.Drawing.Color.Black;
            this.lblCel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCel.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCel.Location = new System.Drawing.Point(25, 260);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(108, 27);
            this.lblCel.TabIndex = 17;
            this.lblCel.Text = "Telefono";
            // 
            // lblDirec
            // 
            this.lblDirec.AutoSize = true;
            this.lblDirec.BackColor = System.Drawing.Color.Black;
            this.lblDirec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDirec.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirec.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDirec.Location = new System.Drawing.Point(25, 218);
            this.lblDirec.Name = "lblDirec";
            this.lblDirec.Size = new System.Drawing.Size(119, 27);
            this.lblDirec.TabIndex = 16;
            this.lblDirec.Text = "Direccion";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Black;
            this.lblDni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDni.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDni.Location = new System.Drawing.Point(25, 176);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(54, 27);
            this.lblDni.TabIndex = 15;
            this.lblDni.Text = "Dni";
            // 
            // lblAgApellido
            // 
            this.lblAgApellido.AutoSize = true;
            this.lblAgApellido.BackColor = System.Drawing.Color.Black;
            this.lblAgApellido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAgApellido.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgApellido.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAgApellido.Location = new System.Drawing.Point(25, 133);
            this.lblAgApellido.Name = "lblAgApellido";
            this.lblAgApellido.Size = new System.Drawing.Size(104, 27);
            this.lblAgApellido.TabIndex = 14;
            this.lblAgApellido.Text = "Apellido";
            // 
            // lblAgNombre
            // 
            this.lblAgNombre.AutoSize = true;
            this.lblAgNombre.BackColor = System.Drawing.Color.Black;
            this.lblAgNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAgNombre.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAgNombre.Location = new System.Drawing.Point(25, 88);
            this.lblAgNombre.Name = "lblAgNombre";
            this.lblAgNombre.Size = new System.Drawing.Size(103, 27);
            this.lblAgNombre.TabIndex = 13;
            this.lblAgNombre.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(367, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 31);
            this.label3.TabIndex = 25;
            this.label3.Text = "Agregar Cliente";
            // 
            // dgvAgregarCliente
            // 
            this.dgvAgregarCliente.AllowUserToAddRows = false;
            this.dgvAgregarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregarCliente.Location = new System.Drawing.Point(380, 87);
            this.dgvAgregarCliente.MultiSelect = false;
            this.dgvAgregarCliente.Name = "dgvAgregarCliente";
            this.dgvAgregarCliente.ReadOnly = true;
            this.dgvAgregarCliente.Size = new System.Drawing.Size(526, 240);
            this.dgvAgregarCliente.TabIndex = 26;
            // 
            // btnGrabarCliente
            // 
            this.btnGrabarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnGrabarCliente.BackgroundImage = global::SistemaEncomienda.Properties.Resources.Material_Icons_e161_0__256;
            this.btnGrabarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGrabarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGrabarCliente.FlatAppearance.BorderSize = 0;
            this.btnGrabarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGrabarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGrabarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabarCliente.Location = new System.Drawing.Point(154, 376);
            this.btnGrabarCliente.Name = "btnGrabarCliente";
            this.btnGrabarCliente.Size = new System.Drawing.Size(105, 88);
            this.btnGrabarCliente.TabIndex = 27;
            this.btnGrabarCliente.UseVisualStyleBackColor = false;
            this.btnGrabarCliente.Click += new System.EventHandler(this.btnGrabarCliente_Click);
            // 
            // btnMostrarClientes
            // 
            this.btnMostrarClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarClientes.BackgroundImage = global::SistemaEncomienda.Properties.Resources.Material_Icons_e235_0__256;
            this.btnMostrarClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMostrarClientes.FlatAppearance.BorderSize = 0;
            this.btnMostrarClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMostrarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMostrarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarClientes.Location = new System.Drawing.Point(451, 376);
            this.btnMostrarClientes.Name = "btnMostrarClientes";
            this.btnMostrarClientes.Size = new System.Drawing.Size(114, 88);
            this.btnMostrarClientes.TabIndex = 28;
            this.btnMostrarClientes.UseVisualStyleBackColor = false;
            this.btnMostrarClientes.Click += new System.EventHandler(this.btnMostrarClientes_Click);
            // 
            // tbCiudadCliente
            // 
            this.tbCiudadCliente.Location = new System.Drawing.Point(154, 343);
            this.tbCiudadCliente.Multiline = true;
            this.tbCiudadCliente.Name = "tbCiudadCliente";
            this.tbCiudadCliente.Size = new System.Drawing.Size(198, 27);
            this.tbCiudadCliente.TabIndex = 30;
            this.tbCiudadCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNomCliente_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(25, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 27);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ciudad";
            // 
            // frmAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaEncomienda.Properties.Resources.fondo_pagina_ff13;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(970, 464);
            this.Controls.Add(this.tbCiudadCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarClientes);
            this.Controls.Add(this.btnGrabarCliente);
            this.Controls.Add(this.dgvAgregarCliente);
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
            this.DoubleBuffered = true;
            this.Name = "frmAgregarCliente";
            this.Load += new System.EventHandler(this.frmAgregarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DataGridView dgvAgregarCliente;
        private System.Windows.Forms.Button btnGrabarCliente;
        private System.Windows.Forms.Button btnMostrarClientes;
        private System.Windows.Forms.TextBox tbCiudadCliente;
        private System.Windows.Forms.Label label1;
    }
}