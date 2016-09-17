namespace SistemaEncomienda
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
            this.tbCodAbuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSucursal = new System.Windows.Forms.DataGridView();
            this.btnRecibido = new System.Windows.Forms.Button();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.dt = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnviosRecibidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEnviosRecibidos
            // 
            this.dgvEnviosRecibidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnviosRecibidos.Location = new System.Drawing.Point(65, 100);
            this.dgvEnviosRecibidos.Name = "dgvEnviosRecibidos";
            this.dgvEnviosRecibidos.Size = new System.Drawing.Size(637, 248);
            this.dgvEnviosRecibidos.TabIndex = 0;
            // 
            // tbCodAbuscar
            // 
            this.tbCodAbuscar.Location = new System.Drawing.Point(598, 42);
            this.tbCodAbuscar.Multiline = true;
            this.tbCodAbuscar.Name = "tbCodAbuscar";
            this.tbCodAbuscar.Size = new System.Drawing.Size(129, 31);
            this.tbCodAbuscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo Paquete";
            // 
            // dgvSucursal
            // 
            this.dgvSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSucursal.Location = new System.Drawing.Point(65, 363);
            this.dgvSucursal.Name = "dgvSucursal";
            this.dgvSucursal.Size = new System.Drawing.Size(637, 248);
            this.dgvSucursal.TabIndex = 3;
            // 
            // btnRecibido
            // 
            this.btnRecibido.Location = new System.Drawing.Point(809, 177);
            this.btnRecibido.Name = "btnRecibido";
            this.btnRecibido.Size = new System.Drawing.Size(81, 56);
            this.btnRecibido.TabIndex = 28;
            this.btnRecibido.Text = "recibido";
            this.btnRecibido.UseVisualStyleBackColor = true;
            this.btnRecibido.Click += new System.EventHandler(this.btnRecibido_Click);
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(815, 275);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(75, 56);
            this.btnTransferir.TabIndex = 29;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            // 
            // dt
            // 
            this.dt.Location = new System.Drawing.Point(473, 12);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(200, 20);
            this.dt.TabIndex = 30;
            this.dt.Visible = false;
            // 
            // frmMenuEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaEncomienda.Properties.Resources.fondo_abstracto_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1174, 649);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.btnRecibido);
            this.Controls.Add(this.dgvSucursal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCodAbuscar);
            this.Controls.Add(this.dgvEnviosRecibidos);
            this.DoubleBuffered = true;
            this.Name = "frmMenuEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuEmpresa";
            this.Load += new System.EventHandler(this.frmMenuEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnviosRecibidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEnviosRecibidos;
        private System.Windows.Forms.TextBox tbCodAbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSucursal;
        private System.Windows.Forms.Button btnRecibido;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.DateTimePicker dt;
    }
}