namespace SistemaEncomienda
{
    partial class frmLogin
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
            this.btnIngresarLogin = new System.Windows.Forms.Button();
            this.tbUsuIngresar = new System.Windows.Forms.TextBox();
            this.tbContraIngresar = new System.Windows.Forms.TextBox();
            this.cbUsuarios = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIngresarLogin
            // 
            this.btnIngresarLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIngresarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarLogin.ForeColor = System.Drawing.Color.Red;
            this.btnIngresarLogin.Location = new System.Drawing.Point(389, 302);
            this.btnIngresarLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresarLogin.Name = "btnIngresarLogin";
            this.btnIngresarLogin.Size = new System.Drawing.Size(140, 54);
            this.btnIngresarLogin.TabIndex = 4;
            this.btnIngresarLogin.Text = "Ingresar";
            this.btnIngresarLogin.UseVisualStyleBackColor = false;
            this.btnIngresarLogin.Click += new System.EventHandler(this.btnIngresarLogin_Click);
            // 
            // tbUsuIngresar
            // 
            this.tbUsuIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tbUsuIngresar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsuIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuIngresar.Location = new System.Drawing.Point(216, 145);
            this.tbUsuIngresar.Multiline = true;
            this.tbUsuIngresar.Name = "tbUsuIngresar";
            this.tbUsuIngresar.Size = new System.Drawing.Size(297, 39);
            this.tbUsuIngresar.TabIndex = 5;
            // 
            // tbContraIngresar
            // 
            this.tbContraIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tbContraIngresar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbContraIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContraIngresar.Location = new System.Drawing.Point(216, 224);
            this.tbContraIngresar.Multiline = true;
            this.tbContraIngresar.Name = "tbContraIngresar";
            this.tbContraIngresar.PasswordChar = '*';
            this.tbContraIngresar.Size = new System.Drawing.Size(297, 39);
            this.tbContraIngresar.TabIndex = 6;
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.FormattingEnabled = true;
            this.cbUsuarios.Location = new System.Drawing.Point(216, 312);
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.Size = new System.Drawing.Size(121, 21);
            this.cbUsuarios.TabIndex = 7;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Black;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.Red;
            this.lblCliente.Location = new System.Drawing.Point(42, 25);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(530, 18);
            this.lblCliente.TabIndex = 8;
            this.lblCliente.Text = "Si eres cliente ingresa con tu nombre completo y dni como password";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImage = global::SistemaEncomienda.Properties.Resources._19828088_Login_Form_Formulario_para_el_sitio_web_la_p_gina_de_inicio_de_sesi_n_de_plantilla_Foto_de_archivo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(602, 403);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cbUsuarios);
            this.Controls.Add(this.tbContraIngresar);
            this.Controls.Add(this.tbUsuIngresar);
            this.Controls.Add(this.btnIngresarLogin);
            this.Name = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarLogin;
        private System.Windows.Forms.TextBox tbUsuIngresar;
        private System.Windows.Forms.TextBox tbContraIngresar;
        private System.Windows.Forms.ComboBox cbUsuarios;
        private System.Windows.Forms.Label lblCliente;
    }
}