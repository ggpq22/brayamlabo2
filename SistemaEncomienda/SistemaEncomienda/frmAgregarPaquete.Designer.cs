namespace SistemaEncomienda
{
    partial class frmAgregarPaquete
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
            this.tbKg = new System.Windows.Forms.TextBox();
            this.tbdirecDest = new System.Windows.Forms.TextBox();
            this.tbciudadCliente = new System.Windows.Forms.TextBox();
            this.tbDniDestinatario = new System.Windows.Forms.TextBox();
            this.tbNomdestinatario = new System.Windows.Forms.TextBox();
            this.lblKg = new System.Windows.Forms.Label();
            this.lblCel = new System.Windows.Forms.Label();
            this.lblciudad = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombrecompleto = new System.Windows.Forms.Label();
            this.dgvAgregarPaquete = new System.Windows.Forms.DataGridView();
            this.lblAgregarPaquete = new System.Windows.Forms.Label();
            this.btnMostrarClientes = new System.Windows.Forms.Button();
            this.btnGrabarPaquete = new System.Windows.Forms.Button();
            this.tbBultos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCodigoPostal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarPaquete)).BeginInit();
            this.SuspendLayout();
            // 
            // tbKg
            // 
            this.tbKg.Location = new System.Drawing.Point(153, 273);
            this.tbKg.Multiline = true;
            this.tbKg.Name = "tbKg";
            this.tbKg.Size = new System.Drawing.Size(198, 27);
            this.tbKg.TabIndex = 36;
            this.tbKg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDniCliente_KeyPress);
            // 
            // tbdirecDest
            // 
            this.tbdirecDest.Location = new System.Drawing.Point(153, 232);
            this.tbdirecDest.Multiline = true;
            this.tbdirecDest.Name = "tbdirecDest";
            this.tbdirecDest.Size = new System.Drawing.Size(158, 27);
            this.tbdirecDest.TabIndex = 35;
            // 
            // tbciudadCliente
            // 
            this.tbciudadCliente.Location = new System.Drawing.Point(153, 190);
            this.tbciudadCliente.Multiline = true;
            this.tbciudadCliente.Name = "tbciudadCliente";
            this.tbciudadCliente.Size = new System.Drawing.Size(158, 27);
            this.tbciudadCliente.TabIndex = 34;
            this.tbciudadCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNomdestinatario_KeyPress);
            // 
            // tbDniDestinatario
            // 
            this.tbDniDestinatario.Location = new System.Drawing.Point(153, 148);
            this.tbDniDestinatario.MaxLength = 8;
            this.tbDniDestinatario.Multiline = true;
            this.tbDniDestinatario.Name = "tbDniDestinatario";
            this.tbDniDestinatario.Size = new System.Drawing.Size(158, 27);
            this.tbDniDestinatario.TabIndex = 33;
            this.tbDniDestinatario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDniCliente_KeyPress);
            // 
            // tbNomdestinatario
            // 
            this.tbNomdestinatario.Location = new System.Drawing.Point(153, 98);
            this.tbNomdestinatario.Multiline = true;
            this.tbNomdestinatario.Name = "tbNomdestinatario";
            this.tbNomdestinatario.Size = new System.Drawing.Size(158, 27);
            this.tbNomdestinatario.TabIndex = 31;
            this.tbNomdestinatario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNomdestinatario_KeyPress);
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.BackColor = System.Drawing.Color.Black;
            this.lblKg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKg.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKg.ForeColor = System.Drawing.SystemColors.Control;
            this.lblKg.Location = new System.Drawing.Point(24, 273);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(69, 27);
            this.lblKg.TabIndex = 30;
            this.lblKg.Text = "Kilos";
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.BackColor = System.Drawing.Color.Black;
            this.lblCel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCel.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCel.Location = new System.Drawing.Point(24, 232);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(119, 27);
            this.lblCel.TabIndex = 29;
            this.lblCel.Text = "Direccion";
            // 
            // lblciudad
            // 
            this.lblciudad.AutoSize = true;
            this.lblciudad.BackColor = System.Drawing.Color.Black;
            this.lblciudad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblciudad.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblciudad.ForeColor = System.Drawing.SystemColors.Control;
            this.lblciudad.Location = new System.Drawing.Point(24, 190);
            this.lblciudad.Name = "lblciudad";
            this.lblciudad.Size = new System.Drawing.Size(91, 27);
            this.lblciudad.TabIndex = 28;
            this.lblciudad.Text = "Ciudad";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Black;
            this.lblDni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDni.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDni.Location = new System.Drawing.Point(24, 148);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(54, 27);
            this.lblDni.TabIndex = 27;
            this.lblDni.Text = "Dni";
            // 
            // lblNombrecompleto
            // 
            this.lblNombrecompleto.AutoSize = true;
            this.lblNombrecompleto.BackColor = System.Drawing.Color.Black;
            this.lblNombrecompleto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombrecompleto.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrecompleto.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombrecompleto.Location = new System.Drawing.Point(24, 98);
            this.lblNombrecompleto.Name = "lblNombrecompleto";
            this.lblNombrecompleto.Size = new System.Drawing.Size(103, 27);
            this.lblNombrecompleto.TabIndex = 25;
            this.lblNombrecompleto.Text = "Nombre";
            // 
            // dgvAgregarPaquete
            // 
            this.dgvAgregarPaquete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregarPaquete.Location = new System.Drawing.Point(375, 98);
            this.dgvAgregarPaquete.Name = "dgvAgregarPaquete";
            this.dgvAgregarPaquete.ReadOnly = true;
            this.dgvAgregarPaquete.Size = new System.Drawing.Size(665, 249);
            this.dgvAgregarPaquete.TabIndex = 37;
            // 
            // lblAgregarPaquete
            // 
            this.lblAgregarPaquete.AutoSize = true;
            this.lblAgregarPaquete.BackColor = System.Drawing.Color.Black;
            this.lblAgregarPaquete.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarPaquete.ForeColor = System.Drawing.Color.Yellow;
            this.lblAgregarPaquete.Location = new System.Drawing.Point(386, 29);
            this.lblAgregarPaquete.Name = "lblAgregarPaquete";
            this.lblAgregarPaquete.Size = new System.Drawing.Size(244, 31);
            this.lblAgregarPaquete.TabIndex = 38;
            this.lblAgregarPaquete.Text = "Agregar Paquete";
            // 
            // btnMostrarClientes
            // 
            this.btnMostrarClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarClientes.BackgroundImage = global::SistemaEncomienda.Properties.Resources.octicons_f007_6__256;
            this.btnMostrarClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMostrarClientes.FlatAppearance.BorderSize = 0;
            this.btnMostrarClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMostrarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMostrarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarClientes.Location = new System.Drawing.Point(392, 410);
            this.btnMostrarClientes.Name = "btnMostrarClientes";
            this.btnMostrarClientes.Size = new System.Drawing.Size(114, 88);
            this.btnMostrarClientes.TabIndex = 40;
            this.btnMostrarClientes.UseVisualStyleBackColor = false;
            this.btnMostrarClientes.Click += new System.EventHandler(this.btnMostrarClientes_Click);
            // 
            // btnGrabarPaquete
            // 
            this.btnGrabarPaquete.BackColor = System.Drawing.Color.Transparent;
            this.btnGrabarPaquete.BackgroundImage = global::SistemaEncomienda.Properties.Resources.Material_Icons_e161_0__256;
            this.btnGrabarPaquete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGrabarPaquete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGrabarPaquete.FlatAppearance.BorderSize = 0;
            this.btnGrabarPaquete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGrabarPaquete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGrabarPaquete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabarPaquete.Location = new System.Drawing.Point(153, 410);
            this.btnGrabarPaquete.Name = "btnGrabarPaquete";
            this.btnGrabarPaquete.Size = new System.Drawing.Size(105, 88);
            this.btnGrabarPaquete.TabIndex = 39;
            this.btnGrabarPaquete.UseVisualStyleBackColor = false;
            this.btnGrabarPaquete.Click += new System.EventHandler(this.btnGrabarPaquete_Click);
            // 
            // tbBultos
            // 
            this.tbBultos.Location = new System.Drawing.Point(154, 320);
            this.tbBultos.Multiline = true;
            this.tbBultos.Name = "tbBultos";
            this.tbBultos.Size = new System.Drawing.Size(105, 27);
            this.tbBultos.TabIndex = 42;
            this.tbBultos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDniCliente_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(25, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 27);
            this.label1.TabIndex = 41;
            this.label1.Text = "Bultos";
            // 
            // tbCodigoPostal
            // 
            this.tbCodigoPostal.Location = new System.Drawing.Point(161, 365);
            this.tbCodigoPostal.Multiline = true;
            this.tbCodigoPostal.Name = "tbCodigoPostal";
            this.tbCodigoPostal.Size = new System.Drawing.Size(105, 27);
            this.tbCodigoPostal.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(24, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 27);
            this.label2.TabIndex = 43;
            this.label2.Text = "Cod-Postal";
            // 
            // frmAgregarPaquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaEncomienda.Properties.Resources.abstract_vector_minimalistic_red_black_1920x1200;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 519);
            this.Controls.Add(this.tbCodigoPostal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBultos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarClientes);
            this.Controls.Add(this.btnGrabarPaquete);
            this.Controls.Add(this.lblAgregarPaquete);
            this.Controls.Add(this.dgvAgregarPaquete);
            this.Controls.Add(this.tbKg);
            this.Controls.Add(this.tbdirecDest);
            this.Controls.Add(this.tbciudadCliente);
            this.Controls.Add(this.tbDniDestinatario);
            this.Controls.Add(this.tbNomdestinatario);
            this.Controls.Add(this.lblKg);
            this.Controls.Add(this.lblCel);
            this.Controls.Add(this.lblciudad);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblNombrecompleto);
            this.DoubleBuffered = true;
            this.Name = "frmAgregarPaquete";
            this.Load += new System.EventHandler(this.frmAgregarPaquete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarPaquete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKg;
        private System.Windows.Forms.TextBox tbdirecDest;
        private System.Windows.Forms.TextBox tbciudadCliente;
        private System.Windows.Forms.TextBox tbDniDestinatario;
        private System.Windows.Forms.TextBox tbNomdestinatario;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.Label lblciudad;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombrecompleto;
        private System.Windows.Forms.DataGridView dgvAgregarPaquete;
        private System.Windows.Forms.Label lblAgregarPaquete;
        private System.Windows.Forms.Button btnMostrarClientes;
        private System.Windows.Forms.Button btnGrabarPaquete;
        private System.Windows.Forms.TextBox tbBultos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCodigoPostal;
        private System.Windows.Forms.Label label2;
    }
}