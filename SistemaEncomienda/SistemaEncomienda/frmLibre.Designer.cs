﻿namespace SistemaEncomienda
{
    partial class frmLibre
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
            this.btnRastrear = new System.Windows.Forms.Button();
            this.btnVerMisenvios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRastrear
            // 
            this.btnRastrear.Location = new System.Drawing.Point(330, 76);
            this.btnRastrear.Name = "btnRastrear";
            this.btnRastrear.Size = new System.Drawing.Size(75, 52);
            this.btnRastrear.TabIndex = 0;
            this.btnRastrear.Text = "button1";
            this.btnRastrear.UseVisualStyleBackColor = true;
            this.btnRastrear.Click += new System.EventHandler(this.btnRastrear_Click);
            // 
            // btnVerMisenvios
            // 
            this.btnVerMisenvios.Location = new System.Drawing.Point(330, 192);
            this.btnVerMisenvios.Name = "btnVerMisenvios";
            this.btnVerMisenvios.Size = new System.Drawing.Size(75, 51);
            this.btnVerMisenvios.TabIndex = 1;
            this.btnVerMisenvios.Text = "button2";
            this.btnVerMisenvios.UseVisualStyleBackColor = true;
            this.btnVerMisenvios.Click += new System.EventHandler(this.btnVerMisenvios_Click);
            // 
            // frmLibre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaEncomienda.Properties.Resources.fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(722, 349);
            this.Controls.Add(this.btnVerMisenvios);
            this.Controls.Add(this.btnRastrear);
            this.DoubleBuffered = true;
            this.Name = "frmLibre";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRastrear;
        private System.Windows.Forms.Button btnVerMisenvios;
    }
}