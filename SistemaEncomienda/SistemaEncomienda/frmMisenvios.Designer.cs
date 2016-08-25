namespace SistemaEncomienda
{
    partial class frmMisenvios
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
            this.dgvPaquetesEnviados = new System.Windows.Forms.DataGridView();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.btnMostrarInfo = new System.Windows.Forms.Button();
            this.tbDniBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetesEnviados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPaquetesEnviados
            // 
            this.dgvPaquetesEnviados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaquetesEnviados.Location = new System.Drawing.Point(93, 76);
            this.dgvPaquetesEnviados.Name = "dgvPaquetesEnviados";
            this.dgvPaquetesEnviados.Size = new System.Drawing.Size(748, 150);
            this.dgvPaquetesEnviados.TabIndex = 0;
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Location = new System.Drawing.Point(93, 303);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.Size = new System.Drawing.Size(748, 150);
            this.dgvFacturas.TabIndex = 1;
            // 
            // btnMostrarInfo
            // 
            this.btnMostrarInfo.Location = new System.Drawing.Point(461, 24);
            this.btnMostrarInfo.Name = "btnMostrarInfo";
            this.btnMostrarInfo.Size = new System.Drawing.Size(75, 35);
            this.btnMostrarInfo.TabIndex = 2;
            this.btnMostrarInfo.Text = "ok";
            this.btnMostrarInfo.UseVisualStyleBackColor = true;
            this.btnMostrarInfo.Click += new System.EventHandler(this.btnMostrarInfo_Click);
            // 
            // tbDniBuscar
            // 
            this.tbDniBuscar.Location = new System.Drawing.Point(287, 24);
            this.tbDniBuscar.Multiline = true;
            this.tbDniBuscar.Name = "tbDniBuscar";
            this.tbDniBuscar.Size = new System.Drawing.Size(139, 35);
            this.tbDniBuscar.TabIndex = 3;
            // 
            // frmMisenvios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 474);
            this.Controls.Add(this.tbDniBuscar);
            this.Controls.Add(this.btnMostrarInfo);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.dgvPaquetesEnviados);
            this.Name = "frmMisenvios";
            this.Text = "frmMisenvios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetesEnviados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPaquetesEnviados;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.Button btnMostrarInfo;
        private System.Windows.Forms.TextBox tbDniBuscar;
    }
}