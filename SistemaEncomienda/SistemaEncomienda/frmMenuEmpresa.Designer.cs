
﻿namespace SistemaEncomienda
{
    partial class frmMenuEmpresa
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
            this.dgvEnviosRecibidos = new System.Windows.Forms.DataGridView();
            this.tbFiltroCodigoPaquete = new System.Windows.Forms.TextBox();
            this.lblCodigoPaquete = new System.Windows.Forms.Label();
            this.dgvSucursal = new System.Windows.Forms.DataGridView();
            this.btnRecibido = new System.Windows.Forms.Button();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.pnlFiltroFechaEnvio = new System.Windows.Forms.Panel();
            this.ckbFiltroFechaEnvioHasta = new System.Windows.Forms.CheckBox();
            this.ckbFiltroFechaEnvioDesde = new System.Windows.Forms.CheckBox();
            this.dtpFiltroFechaEnvioHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFiltroFechaEnvioDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFiltroFechaEnvio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnviosRecibidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursal)).BeginInit();
            this.pnlFiltroFechaEnvio.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEnviosRecibidos
            // 
            this.dgvEnviosRecibidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnviosRecibidos.Location = new System.Drawing.Point(65, 177);
            this.dgvEnviosRecibidos.Name = "dgvEnviosRecibidos";
            this.dgvEnviosRecibidos.Size = new System.Drawing.Size(637, 216);
            this.dgvEnviosRecibidos.TabIndex = 0;
            // 
            // tbFiltroCodigoPaquete
            // 
            this.tbFiltroCodigoPaquete.Location = new System.Drawing.Point(116, 123);
            this.tbFiltroCodigoPaquete.Multiline = true;
            this.tbFiltroCodigoPaquete.Name = "tbFiltroCodigoPaquete";
            this.tbFiltroCodigoPaquete.Size = new System.Drawing.Size(129, 31);
            this.tbFiltroCodigoPaquete.TabIndex = 1;
            this.tbFiltroCodigoPaquete.TextChanged += new System.EventHandler(this.tbFiltroCodigoPaquete_TextChanged);
            // 
            // lblCodigoPaquete
            // 
            this.lblCodigoPaquete.AutoSize = true;
            this.lblCodigoPaquete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPaquete.Location = new System.Drawing.Point(75, 85);
            this.lblCodigoPaquete.Name = "lblCodigoPaquete";
            this.lblCodigoPaquete.Size = new System.Drawing.Size(222, 31);
            this.lblCodigoPaquete.TabIndex = 2;
            this.lblCodigoPaquete.Text = "Codigo Paquete";
            // 
            // dgvSucursal
            // 
            this.dgvSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSucursal.Location = new System.Drawing.Point(65, 408);
            this.dgvSucursal.Name = "dgvSucursal";
            this.dgvSucursal.Size = new System.Drawing.Size(637, 216);
            this.dgvSucursal.TabIndex = 3;
            // 
            // btnRecibido
            // 
            this.btnRecibido.BackColor = System.Drawing.Color.Transparent;
            this.btnRecibido.BackgroundImage = global::SistemaEncomienda.Properties.Resources.Entypo_2713_0__512;
            this.btnRecibido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecibido.FlatAppearance.BorderSize = 0;
            this.btnRecibido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRecibido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRecibido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecibido.Location = new System.Drawing.Point(778, 100);
            this.btnRecibido.Name = "btnRecibido";
            this.btnRecibido.Size = new System.Drawing.Size(186, 160);
            this.btnRecibido.TabIndex = 28;
            this.btnRecibido.UseVisualStyleBackColor = false;
            this.btnRecibido.Click += new System.EventHandler(this.btnRecibido_Click);
            // 
            // btnTransferir
            // 
            this.btnTransferir.BackColor = System.Drawing.Color.Transparent;
            this.btnTransferir.BackgroundImage = global::SistemaEncomienda.Properties.Resources.Entypo_e4ae_0__5121;
            this.btnTransferir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTransferir.FlatAppearance.BorderSize = 0;
            this.btnTransferir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTransferir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTransferir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferir.Location = new System.Drawing.Point(778, 448);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(186, 176);
            this.btnTransferir.TabIndex = 29;
            this.btnTransferir.UseVisualStyleBackColor = false;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // dt
            // 
            this.dt.Location = new System.Drawing.Point(369, 12);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(200, 20);
            this.dt.TabIndex = 30;
            // 
            // btnDevolver
            // 
            this.btnDevolver.BackColor = System.Drawing.Color.Transparent;
            this.btnDevolver.BackgroundImage = global::SistemaEncomienda.Properties.Resources.Entypo_e4ad_0__512;
            this.btnDevolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDevolver.FlatAppearance.BorderSize = 0;
            this.btnDevolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDevolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolver.Location = new System.Drawing.Point(778, 290);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(186, 152);
            this.btnDevolver.TabIndex = 31;
            this.btnDevolver.UseVisualStyleBackColor = false;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // pnlFiltroFechaEnvio
            // 
            this.pnlFiltroFechaEnvio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFiltroFechaEnvio.Controls.Add(this.ckbFiltroFechaEnvioHasta);
            this.pnlFiltroFechaEnvio.Controls.Add(this.ckbFiltroFechaEnvioDesde);
            this.pnlFiltroFechaEnvio.Controls.Add(this.dtpFiltroFechaEnvioHasta);
            this.pnlFiltroFechaEnvio.Controls.Add(this.dtpFiltroFechaEnvioDesde);
            this.pnlFiltroFechaEnvio.Controls.Add(this.lblFiltroFechaEnvio);
            this.pnlFiltroFechaEnvio.Location = new System.Drawing.Point(321, 87);
            this.pnlFiltroFechaEnvio.Name = "pnlFiltroFechaEnvio";
            this.pnlFiltroFechaEnvio.Size = new System.Drawing.Size(371, 67);
            this.pnlFiltroFechaEnvio.TabIndex = 32;
            // 
            // ckbFiltroFechaEnvioHasta
            // 
            this.ckbFiltroFechaEnvioHasta.AutoSize = true;
            this.ckbFiltroFechaEnvioHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbFiltroFechaEnvioHasta.Location = new System.Drawing.Point(133, 34);
            this.ckbFiltroFechaEnvioHasta.Name = "ckbFiltroFechaEnvioHasta";
            this.ckbFiltroFechaEnvioHasta.Size = new System.Drawing.Size(64, 19);
            this.ckbFiltroFechaEnvioHasta.TabIndex = 26;
            this.ckbFiltroFechaEnvioHasta.TabStop = false;
            this.ckbFiltroFechaEnvioHasta.Text = "Hasta :";
            this.ckbFiltroFechaEnvioHasta.UseVisualStyleBackColor = true;
            this.ckbFiltroFechaEnvioHasta.CheckedChanged += new System.EventHandler(this.tbFiltroCodigoPaquete_TextChanged);
            // 
            // ckbFiltroFechaEnvioDesde
            // 
            this.ckbFiltroFechaEnvioDesde.AutoSize = true;
            this.ckbFiltroFechaEnvioDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbFiltroFechaEnvioDesde.Location = new System.Drawing.Point(133, 10);
            this.ckbFiltroFechaEnvioDesde.Name = "ckbFiltroFechaEnvioDesde";
            this.ckbFiltroFechaEnvioDesde.Size = new System.Drawing.Size(68, 19);
            this.ckbFiltroFechaEnvioDesde.TabIndex = 25;
            this.ckbFiltroFechaEnvioDesde.TabStop = false;
            this.ckbFiltroFechaEnvioDesde.Text = "Desde :";
            this.ckbFiltroFechaEnvioDesde.UseVisualStyleBackColor = true;
            this.ckbFiltroFechaEnvioDesde.CheckedChanged += new System.EventHandler(this.tbFiltroCodigoPaquete_TextChanged);
            // 
            // dtpFiltroFechaEnvioHasta
            // 
            this.dtpFiltroFechaEnvioHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFiltroFechaEnvioHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFiltroFechaEnvioHasta.Location = new System.Drawing.Point(207, 33);
            this.dtpFiltroFechaEnvioHasta.MaxDate = new System.DateTime(2030, 12, 30, 0, 0, 0, 0);
            this.dtpFiltroFechaEnvioHasta.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFiltroFechaEnvioHasta.Name = "dtpFiltroFechaEnvioHasta";
            this.dtpFiltroFechaEnvioHasta.Size = new System.Drawing.Size(146, 20);
            this.dtpFiltroFechaEnvioHasta.TabIndex = 24;
            this.dtpFiltroFechaEnvioHasta.TabStop = false;
            this.dtpFiltroFechaEnvioHasta.ValueChanged += new System.EventHandler(this.tbFiltroCodigoPaquete_TextChanged);
            // 
            // dtpFiltroFechaEnvioDesde
            // 
            this.dtpFiltroFechaEnvioDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFiltroFechaEnvioDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFiltroFechaEnvioDesde.Location = new System.Drawing.Point(207, 7);
            this.dtpFiltroFechaEnvioDesde.MaxDate = new System.DateTime(2030, 12, 30, 0, 0, 0, 0);
            this.dtpFiltroFechaEnvioDesde.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFiltroFechaEnvioDesde.Name = "dtpFiltroFechaEnvioDesde";
            this.dtpFiltroFechaEnvioDesde.Size = new System.Drawing.Size(146, 20);
            this.dtpFiltroFechaEnvioDesde.TabIndex = 23;
            this.dtpFiltroFechaEnvioDesde.TabStop = false;
            this.dtpFiltroFechaEnvioDesde.ValueChanged += new System.EventHandler(this.tbFiltroCodigoPaquete_TextChanged);
            // 
            // lblFiltroFechaEnvio
            // 
            this.lblFiltroFechaEnvio.AutoSize = true;
            this.lblFiltroFechaEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroFechaEnvio.Location = new System.Drawing.Point(12, 24);
            this.lblFiltroFechaEnvio.Name = "lblFiltroFechaEnvio";
            this.lblFiltroFechaEnvio.Size = new System.Drawing.Size(102, 16);
            this.lblFiltroFechaEnvio.TabIndex = 9;
            this.lblFiltroFechaEnvio.Text = "Fecha Envio :";
            // 
            // frmMenuEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaEncomienda.Properties.Resources.fondo_negro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1037, 741);
            this.Controls.Add(this.pnlFiltroFechaEnvio);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.btnRecibido);
            this.Controls.Add(this.dgvSucursal);
            this.Controls.Add(this.lblCodigoPaquete);
            this.Controls.Add(this.tbFiltroCodigoPaquete);
            this.Controls.Add(this.dgvEnviosRecibidos);
            this.DoubleBuffered = true;
            this.Name = "frmMenuEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuEmpresa";
            this.Load += new System.EventHandler(this.frmMenuEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnviosRecibidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursal)).EndInit();
            this.pnlFiltroFechaEnvio.ResumeLayout(false);
            this.pnlFiltroFechaEnvio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEnviosRecibidos;
        private System.Windows.Forms.TextBox tbFiltroCodigoPaquete;
        private System.Windows.Forms.Label lblCodigoPaquete;
        private System.Windows.Forms.DataGridView dgvSucursal;
        private System.Windows.Forms.Button btnRecibido;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.DateTimePicker dt;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Panel pnlFiltroFechaEnvio;
        private System.Windows.Forms.CheckBox ckbFiltroFechaEnvioHasta;
        private System.Windows.Forms.CheckBox ckbFiltroFechaEnvioDesde;
        private System.Windows.Forms.DateTimePicker dtpFiltroFechaEnvioHasta;
        private System.Windows.Forms.DateTimePicker dtpFiltroFechaEnvioDesde;
        private System.Windows.Forms.Label lblFiltroFechaEnvio;
    }
}