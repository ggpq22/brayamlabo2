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
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.btnMostrarInfo = new System.Windows.Forms.Button();
            this.tbDniBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Location = new System.Drawing.Point(116, 100);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.Size = new System.Drawing.Size(748, 313);
            this.dgvFacturas.TabIndex = 1;
            // 
            // btnMostrarInfo
            // 
            this.btnMostrarInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarInfo.BackgroundImage = global::SistemaEncomienda.Properties.Resources.Iconia_41_2__256;
            this.btnMostrarInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMostrarInfo.FlatAppearance.BorderSize = 0;
            this.btnMostrarInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMostrarInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMostrarInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarInfo.Location = new System.Drawing.Point(532, 12);
            this.btnMostrarInfo.Name = "btnMostrarInfo";
            this.btnMostrarInfo.Size = new System.Drawing.Size(91, 65);
            this.btnMostrarInfo.TabIndex = 2;
            this.btnMostrarInfo.UseVisualStyleBackColor = false;
            this.btnMostrarInfo.Click += new System.EventHandler(this.btnMostrarInfo_Click);
            // 
            // tbDniBuscar
            // 
            this.tbDniBuscar.Location = new System.Drawing.Point(374, 25);
            this.tbDniBuscar.Multiline = true;
            this.tbDniBuscar.Name = "tbDniBuscar";
            this.tbDniBuscar.Size = new System.Drawing.Size(139, 35);
            this.tbDniBuscar.TabIndex = 3;
            this.tbDniBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDniBuscar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese su DNI";
            // 
            // frmMisenvios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaEncomienda.Properties.Resources.Wallpapers_room_com___Wood_I_clean_by_abh83_1280x800;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 474);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDniBuscar);
            this.Controls.Add(this.btnMostrarInfo);
            this.Controls.Add(this.dgvFacturas);
            this.Name = "frmMisenvios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.Button btnMostrarInfo;
        private System.Windows.Forms.TextBox tbDniBuscar;
        private System.Windows.Forms.Label label1;
    }
}