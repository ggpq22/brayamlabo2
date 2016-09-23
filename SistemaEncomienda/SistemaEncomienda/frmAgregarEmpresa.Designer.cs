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
            this.dgvEmpresa = new System.Windows.Forms.DataGridView();
            this.tbDireccionEmpresa = new System.Windows.Forms.TextBox();
            this.tbCiudad = new System.Windows.Forms.TextBox();
            this.tbNomEmpresa = new System.Windows.Forms.TextBox();
            this.lblCel = new System.Windows.Forms.Label();
            this.lblDirec = new System.Windows.Forms.Label();
            this.lblAgApellido = new System.Windows.Forms.Label();
            this.lblAgNombre = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.tbCodP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpresa
            // 
            this.dgvEmpresa.AllowUserToAddRows = false;
            this.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresa.Location = new System.Drawing.Point(365, 89);
            this.dgvEmpresa.MultiSelect = false;
            this.dgvEmpresa.Name = "dgvEmpresa";
            this.dgvEmpresa.ReadOnly = true;
            this.dgvEmpresa.Size = new System.Drawing.Size(432, 188);
            this.dgvEmpresa.TabIndex = 39;
            // 
            // tbDireccionEmpresa
            // 
            this.tbDireccionEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDireccionEmpresa.Location = new System.Drawing.Point(214, 190);
            this.tbDireccionEmpresa.Name = "tbDireccionEmpresa";
            this.tbDireccionEmpresa.Size = new System.Drawing.Size(105, 22);
            this.tbDireccionEmpresa.TabIndex = 2;
            // 
            // tbCiudad
            // 
            this.tbCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCiudad.Location = new System.Drawing.Point(214, 134);
            this.tbCiudad.Name = "tbCiudad";
            this.tbCiudad.Size = new System.Drawing.Size(105, 22);
            this.tbCiudad.TabIndex = 1;
            this.tbCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNomEmpresa_KeyPress);
            // 
            // tbNomEmpresa
            // 
            this.tbNomEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomEmpresa.Location = new System.Drawing.Point(214, 89);
            this.tbNomEmpresa.Name = "tbNomEmpresa";
            this.tbNomEmpresa.Size = new System.Drawing.Size(105, 22);
            this.tbNomEmpresa.TabIndex = 0;
            this.tbNomEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNomEmpresa_KeyPress);
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
            this.tbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefono.Location = new System.Drawing.Point(214, 242);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(105, 22);
            this.tbTelefono.TabIndex = 3;
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefono_KeyPress);
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
            this.btnGrabar.Location = new System.Drawing.Point(214, 316);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(105, 101);
            this.btnGrabar.TabIndex = 40;
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // tbCodP
            // 
            this.tbCodP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodP.Location = new System.Drawing.Point(214, 292);
            this.tbCodP.MaxLength = 4;
            this.tbCodP.Name = "tbCodP";
            this.tbCodP.Size = new System.Drawing.Size(105, 22);
            this.tbCodP.TabIndex = 4;
            this.tbCodP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefono_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(58, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 27);
            this.label1.TabIndex = 42;
            this.label1.Text = "Cod-Postal";
            // 
            // frmAgregarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaEncomienda.Properties.Resources.AA1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 418);
            this.Controls.Add(this.tbCodP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.dgvEmpresa);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpresa;
        private System.Windows.Forms.TextBox tbDireccionEmpresa;
        private System.Windows.Forms.TextBox tbCiudad;
        private System.Windows.Forms.TextBox tbNomEmpresa;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.Label lblDirec;
        private System.Windows.Forms.Label lblAgApellido;
        private System.Windows.Forms.Label lblAgNombre;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox tbCodP;
        private System.Windows.Forms.Label label1;
    }
}