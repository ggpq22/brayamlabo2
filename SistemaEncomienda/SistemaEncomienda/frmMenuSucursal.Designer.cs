namespace SistemaEncomienda
{
    partial class frmMenuSucursal
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRecibido = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.dt = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnviosRecibidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEnviosRecibidos
            // 
            this.dgvEnviosRecibidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnviosRecibidos.Location = new System.Drawing.Point(90, 92);
            this.dgvEnviosRecibidos.Name = "dgvEnviosRecibidos";
            this.dgvEnviosRecibidos.Size = new System.Drawing.Size(696, 310);
            this.dgvEnviosRecibidos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cod-Paquete";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(263, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 29);
            this.textBox1.TabIndex = 2;
            // 
            // btnRecibido
            // 
            this.btnRecibido.Location = new System.Drawing.Point(206, 431);
            this.btnRecibido.Name = "btnRecibido";
            this.btnRecibido.Size = new System.Drawing.Size(75, 50);
            this.btnRecibido.TabIndex = 3;
            this.btnRecibido.Text = "btnRecibido";
            this.btnRecibido.UseVisualStyleBackColor = true;
            this.btnRecibido.Click += new System.EventHandler(this.btnRecibido_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(324, 431);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(75, 50);
            this.btnDevolver.TabIndex = 4;
            this.btnDevolver.Text = "btnDevolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            // 
            // dt
            // 
            this.dt.Location = new System.Drawing.Point(444, 22);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(200, 20);
            this.dt.TabIndex = 5;
            // 
            // frmMenuSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaEncomienda.Properties.Resources.bge02;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(879, 512);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.btnRecibido);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEnviosRecibidos);
            this.Name = "frmMenuSucursal";
            this.Text = "frmMenuSucursal";
            this.Load += new System.EventHandler(this.frmMenuSucursal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnviosRecibidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEnviosRecibidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRecibido;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.DateTimePicker dt;
    }
}