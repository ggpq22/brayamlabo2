﻿namespace SistemaEncomienda
{
    partial class frmRastrearPaquete
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCodigoAbuscar = new System.Windows.Forms.TextBox();
            this.btnRastrear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(218, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(474, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el codigo de su paquete para verificar el estado";
            // 
            // tbCodigoAbuscar
            // 
            this.tbCodigoAbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoAbuscar.Location = new System.Drawing.Point(242, 128);
            this.tbCodigoAbuscar.MaxLength = 10;
            this.tbCodigoAbuscar.Name = "tbCodigoAbuscar";
            this.tbCodigoAbuscar.Size = new System.Drawing.Size(153, 35);
            this.tbCodigoAbuscar.TabIndex = 2;
            // 
            // btnRastrear
            // 
            this.btnRastrear.Location = new System.Drawing.Point(274, 246);
            this.btnRastrear.Name = "btnRastrear";
            this.btnRastrear.Size = new System.Drawing.Size(75, 46);
            this.btnRastrear.TabIndex = 3;
            this.btnRastrear.Text = "Rastrear";
            this.btnRastrear.UseVisualStyleBackColor = true;
            this.btnRastrear.Click += new System.EventHandler(this.btnRastrear_Click);
            // 
            // frmRastrearPaquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaEncomienda.Properties.Resources.Aquaris_E10_wallpaper_v1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(631, 386);
            this.Controls.Add(this.btnRastrear);
            this.Controls.Add(this.tbCodigoAbuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "frmRastrearPaquete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCodigoAbuscar;
        private System.Windows.Forms.Button btnRastrear;
    }
}