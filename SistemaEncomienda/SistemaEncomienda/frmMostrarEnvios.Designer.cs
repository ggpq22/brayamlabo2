namespace SistemaEncomienda
{
    partial class frmMostrarEnvios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.gbFiltrosDatos = new System.Windows.Forms.GroupBox();
            this.pnlFiltroGenerales = new System.Windows.Forms.Panel();
            this.tbFiltroDniCliente = new System.Windows.Forms.TextBox();
            this.tbFiltroNombreCliente = new System.Windows.Forms.TextBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.pnlFiltroFechaEnvio = new System.Windows.Forms.Panel();
            this.ckbFiltroFechaEnvioHasta = new System.Windows.Forms.CheckBox();
            this.ckbFiltroFechaEnvioDesde = new System.Windows.Forms.CheckBox();
            this.dtpFiltroFechaEnvioHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFiltroFechaEnvioDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFiltroFechaEnvio = new System.Windows.Forms.Label();
            this.lblAyuda1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.gbFiltrosDatos.SuspendLayout();
            this.pnlFiltroGenerales.SuspendLayout();
            this.pnlFiltroFechaEnvio.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.AllowUserToAddRows = false;
            this.dgvMostrar.AllowUserToDeleteRows = false;
            this.dgvMostrar.AllowUserToResizeColumns = false;
            this.dgvMostrar.AllowUserToResizeRows = false;
            this.dgvMostrar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostrar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMostrar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMostrar.Location = new System.Drawing.Point(86, 305);
            this.dgvMostrar.MultiSelect = false;
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.ReadOnly = true;
            this.dgvMostrar.RowHeadersVisible = false;
            this.dgvMostrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMostrar.Size = new System.Drawing.Size(835, 292);
            this.dgvMostrar.TabIndex = 64;
            this.dgvMostrar.TabStop = false;
            // 
            // gbFiltrosDatos
            // 
            this.gbFiltrosDatos.BackColor = System.Drawing.Color.Transparent;
            this.gbFiltrosDatos.Controls.Add(this.pnlFiltroGenerales);
            this.gbFiltrosDatos.Controls.Add(this.pnlFiltroFechaEnvio);
            this.gbFiltrosDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltrosDatos.ForeColor = System.Drawing.Color.White;
            this.gbFiltrosDatos.Location = new System.Drawing.Point(86, 63);
            this.gbFiltrosDatos.Name = "gbFiltrosDatos";
            this.gbFiltrosDatos.Size = new System.Drawing.Size(835, 196);
            this.gbFiltrosDatos.TabIndex = 65;
            this.gbFiltrosDatos.TabStop = false;
            this.gbFiltrosDatos.Text = "Filtros de Datos";
            // 
            // pnlFiltroGenerales
            // 
            this.pnlFiltroGenerales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFiltroGenerales.Controls.Add(this.tbFiltroDniCliente);
            this.pnlFiltroGenerales.Controls.Add(this.tbFiltroNombreCliente);
            this.pnlFiltroGenerales.Controls.Add(this.lblEmpresa);
            this.pnlFiltroGenerales.Controls.Add(this.cbEmpresa);
            this.pnlFiltroGenerales.Controls.Add(this.lblDNI);
            this.pnlFiltroGenerales.Controls.Add(this.lblNombreCliente);
            this.pnlFiltroGenerales.Location = new System.Drawing.Point(59, 33);
            this.pnlFiltroGenerales.Name = "pnlFiltroGenerales";
            this.pnlFiltroGenerales.Size = new System.Drawing.Size(713, 59);
            this.pnlFiltroGenerales.TabIndex = 29;
            // 
            // tbFiltroDniCliente
            // 
            this.tbFiltroDniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltroDniCliente.Location = new System.Drawing.Point(546, 18);
            this.tbFiltroDniCliente.MaxLength = 8;
            this.tbFiltroDniCliente.Name = "tbFiltroDniCliente";
            this.tbFiltroDniCliente.Size = new System.Drawing.Size(130, 24);
            this.tbFiltroDniCliente.TabIndex = 1;
            this.tbFiltroDniCliente.TextChanged += new System.EventHandler(this.cbEmpresa_SelectedIndexChanged);
            this.tbFiltroDniCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFiltroDniCliente_KeyPress);
            // 
            // tbFiltroNombreCliente
            // 
            this.tbFiltroNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltroNombreCliente.Location = new System.Drawing.Point(348, 18);
            this.tbFiltroNombreCliente.MaxLength = 50;
            this.tbFiltroNombreCliente.Name = "tbFiltroNombreCliente";
            this.tbFiltroNombreCliente.Size = new System.Drawing.Size(130, 24);
            this.tbFiltroNombreCliente.TabIndex = 0;
            this.tbFiltroNombreCliente.TextChanged += new System.EventHandler(this.cbEmpresa_SelectedIndexChanged);
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(30, 22);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(78, 16);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Empresa :";
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Location = new System.Drawing.Point(121, 18);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(130, 24);
            this.cbEmpresa.TabIndex = 1;
            this.cbEmpresa.TabStop = false;
            this.cbEmpresa.SelectedIndexChanged += new System.EventHandler(this.cbEmpresa_SelectedIndexChanged);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(491, 22);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(42, 16);
            this.lblDNI.TabIndex = 4;
            this.lblDNI.Text = "DNI :";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(264, 22);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(71, 16);
            this.lblNombreCliente.TabIndex = 2;
            this.lblNombreCliente.Text = "Nombre :";
            // 
            // pnlFiltroFechaEnvio
            // 
            this.pnlFiltroFechaEnvio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFiltroFechaEnvio.Controls.Add(this.ckbFiltroFechaEnvioHasta);
            this.pnlFiltroFechaEnvio.Controls.Add(this.ckbFiltroFechaEnvioDesde);
            this.pnlFiltroFechaEnvio.Controls.Add(this.dtpFiltroFechaEnvioHasta);
            this.pnlFiltroFechaEnvio.Controls.Add(this.dtpFiltroFechaEnvioDesde);
            this.pnlFiltroFechaEnvio.Controls.Add(this.lblFiltroFechaEnvio);
            this.pnlFiltroFechaEnvio.Location = new System.Drawing.Point(219, 109);
            this.pnlFiltroFechaEnvio.Name = "pnlFiltroFechaEnvio";
            this.pnlFiltroFechaEnvio.Size = new System.Drawing.Size(375, 68);
            this.pnlFiltroFechaEnvio.TabIndex = 23;
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
            this.ckbFiltroFechaEnvioHasta.CheckedChanged += new System.EventHandler(this.cbEmpresa_SelectedIndexChanged);
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
            this.ckbFiltroFechaEnvioDesde.CheckedChanged += new System.EventHandler(this.cbEmpresa_SelectedIndexChanged);
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
            this.dtpFiltroFechaEnvioHasta.ValueChanged += new System.EventHandler(this.cbEmpresa_SelectedIndexChanged);
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
            this.dtpFiltroFechaEnvioDesde.ValueChanged += new System.EventHandler(this.cbEmpresa_SelectedIndexChanged);
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
            // lblAyuda1
            // 
            this.lblAyuda1.AutoSize = true;
            this.lblAyuda1.BackColor = System.Drawing.Color.Transparent;
            this.lblAyuda1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyuda1.ForeColor = System.Drawing.Color.White;
            this.lblAyuda1.Location = new System.Drawing.Point(95, 286);
            this.lblAyuda1.Name = "lblAyuda1";
            this.lblAyuda1.Size = new System.Drawing.Size(109, 16);
            this.lblAyuda1.TabIndex = 75;
            this.lblAyuda1.Text = "Detalle del envio";
            // 
            // frmMostrarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaEncomienda.Properties.Resources.windows_wallpaper_screen_logon_images_logonscreens_thoosje_check_42786;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1026, 619);
            this.Controls.Add(this.lblAyuda1);
            this.Controls.Add(this.gbFiltrosDatos);
            this.Controls.Add(this.dgvMostrar);
            this.Name = "frmMostrarVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMostrarVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.gbFiltrosDatos.ResumeLayout(false);
            this.pnlFiltroGenerales.ResumeLayout(false);
            this.pnlFiltroGenerales.PerformLayout();
            this.pnlFiltroFechaEnvio.ResumeLayout(false);
            this.pnlFiltroFechaEnvio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.GroupBox gbFiltrosDatos;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Panel pnlFiltroGenerales;
        private System.Windows.Forms.Panel pnlFiltroFechaEnvio;
        private System.Windows.Forms.CheckBox ckbFiltroFechaEnvioHasta;
        private System.Windows.Forms.CheckBox ckbFiltroFechaEnvioDesde;
        private System.Windows.Forms.DateTimePicker dtpFiltroFechaEnvioHasta;
        private System.Windows.Forms.DateTimePicker dtpFiltroFechaEnvioDesde;
        private System.Windows.Forms.Label lblFiltroFechaEnvio;
        private System.Windows.Forms.TextBox tbFiltroDniCliente;
        private System.Windows.Forms.TextBox tbFiltroNombreCliente;
        private System.Windows.Forms.Label lblAyuda1;
    }
}