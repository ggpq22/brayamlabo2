namespace SistemaEncomienda
{
    partial class frmVerCuentas
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
            this.dgvMostrarCuentas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostrarCuentas
            // 
            this.dgvMostrarCuentas.AllowUserToAddRows = false;
            this.dgvMostrarCuentas.AllowUserToDeleteRows = false;
            this.dgvMostrarCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarCuentas.Location = new System.Drawing.Point(135, 64);
            this.dgvMostrarCuentas.Name = "dgvMostrarCuentas";
            this.dgvMostrarCuentas.ReadOnly = true;
            this.dgvMostrarCuentas.Size = new System.Drawing.Size(447, 287);
            this.dgvMostrarCuentas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cuentas de Usuarios";
            // 
            // frmVerCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaEncomienda.Properties.Resources.fondoOtro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(713, 351);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMostrarCuentas);
            this.Name = "frmVerCuentas";
            this.Text = "frmVerCuentas";
            this.Load += new System.EventHandler(this.frmVerCuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrarCuentas;
        private System.Windows.Forms.Label label1;
    }
}