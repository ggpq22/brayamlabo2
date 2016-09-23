namespace SistemaEncomienda
{
    partial class frmAgregarSucursal
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
            this.dgvAgregarPaquete = new System.Windows.Forms.DataGridView();
            this.tbCodPostal = new System.Windows.Forms.TextBox();
            this.tbProvincia = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbLocalidad = new System.Windows.Forms.TextBox();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblCel = new System.Windows.Forms.Label();
            this.lblciudad = new System.Windows.Forms.Label();
            this.lblNombrecompleto = new System.Windows.Forms.Label();
            this.btnGrabarSucursal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarPaquete)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAgregarPaquete
            // 
            this.dgvAgregarPaquete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregarPaquete.Location = new System.Drawing.Point(378, 55);
            this.dgvAgregarPaquete.Name = "dgvAgregarPaquete";
            this.dgvAgregarPaquete.ReadOnly = true;
            this.dgvAgregarPaquete.Size = new System.Drawing.Size(511, 212);
            this.dgvAgregarPaquete.TabIndex = 53;
            // 
            // tbCodPostal
            // 
            this.tbCodPostal.Location = new System.Drawing.Point(165, 189);
            this.tbCodPostal.Multiline = true;
            this.tbCodPostal.Name = "tbCodPostal";
            this.tbCodPostal.Size = new System.Drawing.Size(81, 27);
            this.tbCodPostal.TabIndex = 51;
            // 
            // tbProvincia
            // 
            this.tbProvincia.Location = new System.Drawing.Point(165, 147);
            this.tbProvincia.Multiline = true;
            this.tbProvincia.Name = "tbProvincia";
            this.tbProvincia.Size = new System.Drawing.Size(81, 27);
            this.tbProvincia.TabIndex = 50;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(165, 105);
            this.tbDireccion.MaxLength = 8;
            this.tbDireccion.Multiline = true;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(137, 27);
            this.tbDireccion.TabIndex = 49;
            // 
            // tbLocalidad
            // 
            this.tbLocalidad.Location = new System.Drawing.Point(165, 55);
            this.tbLocalidad.Multiline = true;
            this.tbLocalidad.Name = "tbLocalidad";
            this.tbLocalidad.Size = new System.Drawing.Size(137, 27);
            this.tbLocalidad.TabIndex = 48;
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.BackColor = System.Drawing.Color.Black;
            this.lblCP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCP.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCP.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCP.Location = new System.Drawing.Point(28, 189);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(131, 27);
            this.lblCP.TabIndex = 47;
            this.lblCP.Text = "Cod-Postal";
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.BackColor = System.Drawing.Color.Black;
            this.lblCel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCel.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCel.Location = new System.Drawing.Point(28, 105);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(119, 27);
            this.lblCel.TabIndex = 46;
            this.lblCel.Text = "Direccion";
            // 
            // lblciudad
            // 
            this.lblciudad.AutoSize = true;
            this.lblciudad.BackColor = System.Drawing.Color.Black;
            this.lblciudad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblciudad.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblciudad.ForeColor = System.Drawing.SystemColors.Control;
            this.lblciudad.Location = new System.Drawing.Point(27, 147);
            this.lblciudad.Name = "lblciudad";
            this.lblciudad.Size = new System.Drawing.Size(118, 27);
            this.lblciudad.TabIndex = 45;
            this.lblciudad.Text = "Provincia";
            // 
            // lblNombrecompleto
            // 
            this.lblNombrecompleto.AutoSize = true;
            this.lblNombrecompleto.BackColor = System.Drawing.Color.Black;
            this.lblNombrecompleto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombrecompleto.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrecompleto.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombrecompleto.Location = new System.Drawing.Point(27, 55);
            this.lblNombrecompleto.Name = "lblNombrecompleto";
            this.lblNombrecompleto.Size = new System.Drawing.Size(120, 27);
            this.lblNombrecompleto.TabIndex = 43;
            this.lblNombrecompleto.Text = "Localidad";
            // 
            // btnGrabarSucursal
            // 
            this.btnGrabarSucursal.BackColor = System.Drawing.Color.Transparent;
            this.btnGrabarSucursal.BackgroundImage = global::SistemaEncomienda.Properties.Resources.Material_Icons_e161_0__2562;
            this.btnGrabarSucursal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGrabarSucursal.FlatAppearance.BorderSize = 0;
            this.btnGrabarSucursal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGrabarSucursal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGrabarSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabarSucursal.Location = new System.Drawing.Point(165, 296);
            this.btnGrabarSucursal.Name = "btnGrabarSucursal";
            this.btnGrabarSucursal.Size = new System.Drawing.Size(113, 91);
            this.btnGrabarSucursal.TabIndex = 54;
            this.btnGrabarSucursal.UseVisualStyleBackColor = false;
            this.btnGrabarSucursal.Click += new System.EventHandler(this.btnGrabarSucursal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(378, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 27);
            this.label1.TabIndex = 56;
            this.label1.Text = "Agregar Sucursal";
            // 
            // frmAgregarSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaEncomienda.Properties.Resources._23214wide;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 435);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGrabarSucursal);
            this.Controls.Add(this.dgvAgregarPaquete);
            this.Controls.Add(this.tbCodPostal);
            this.Controls.Add(this.tbProvincia);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbLocalidad);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.lblCel);
            this.Controls.Add(this.lblciudad);
            this.Controls.Add(this.lblNombrecompleto);
            this.Name = "frmAgregarSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAgregarSucursal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarPaquete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAgregarPaquete;
        private System.Windows.Forms.TextBox tbCodPostal;
        private System.Windows.Forms.TextBox tbProvincia;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbLocalidad;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.Label lblciudad;
        private System.Windows.Forms.Label lblNombrecompleto;
        private System.Windows.Forms.Button btnGrabarSucursal;
        private System.Windows.Forms.Label label1;
    }
}