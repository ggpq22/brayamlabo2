namespace SistemaEncomienda
{
    partial class frmRegistrarse
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
            this.pnlImagen = new System.Windows.Forms.Panel();
            this.tbContraRegistro = new System.Windows.Forms.TextBox();
            this.tbNomUsuarioRegistro = new System.Windows.Forms.TextBox();
            this.tbNomCompletoRegistro = new System.Windows.Forms.TextBox();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.lblNomCompleto = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblNomUsuario = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlImagen
            // 
            this.pnlImagen.BackgroundImage = global::SistemaEncomienda.Properties.Resources.user_add_26863;
            this.pnlImagen.Location = new System.Drawing.Point(37, 93);
            this.pnlImagen.Name = "pnlImagen";
            this.pnlImagen.Size = new System.Drawing.Size(236, 231);
            this.pnlImagen.TabIndex = 3;
            // 
            // tbContraRegistro
            // 
            this.tbContraRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbContraRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContraRegistro.Location = new System.Drawing.Point(480, 185);
            this.tbContraRegistro.MinimumSize = new System.Drawing.Size(130, 25);
            this.tbContraRegistro.Multiline = true;
            this.tbContraRegistro.Name = "tbContraRegistro";
            this.tbContraRegistro.PasswordChar = '*';
            this.tbContraRegistro.Size = new System.Drawing.Size(150, 25);
            this.tbContraRegistro.TabIndex = 15;
            // 
            // tbNomUsuarioRegistro
            // 
            this.tbNomUsuarioRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNomUsuarioRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomUsuarioRegistro.Location = new System.Drawing.Point(480, 139);
            this.tbNomUsuarioRegistro.MinimumSize = new System.Drawing.Size(130, 25);
            this.tbNomUsuarioRegistro.Multiline = true;
            this.tbNomUsuarioRegistro.Name = "tbNomUsuarioRegistro";
            this.tbNomUsuarioRegistro.Size = new System.Drawing.Size(150, 25);
            this.tbNomUsuarioRegistro.TabIndex = 14;
            // 
            // tbNomCompletoRegistro
            // 
            this.tbNomCompletoRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNomCompletoRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomCompletoRegistro.Location = new System.Drawing.Point(480, 93);
            this.tbNomCompletoRegistro.MinimumSize = new System.Drawing.Size(130, 25);
            this.tbNomCompletoRegistro.Multiline = true;
            this.tbNomCompletoRegistro.Name = "tbNomCompletoRegistro";
            this.tbNomCompletoRegistro.Size = new System.Drawing.Size(150, 25);
            this.tbNomCompletoRegistro.TabIndex = 13;
            this.tbNomCompletoRegistro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNomCompletoRegistro_KeyPress);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.Black;
            this.btnRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.ForeColor = System.Drawing.Color.Red;
            this.btnRegistrarse.Location = new System.Drawing.Point(480, 337);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(106, 49);
            this.btnRegistrarse.TabIndex = 12;
            this.btnRegistrarse.Tag = "";
            this.btnRegistrarse.Text = "Guardar";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // lblNomCompleto
            // 
            this.lblNomCompleto.AutoSize = true;
            this.lblNomCompleto.BackColor = System.Drawing.Color.Transparent;
            this.lblNomCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomCompleto.Location = new System.Drawing.Point(286, 94);
            this.lblNomCompleto.Name = "lblNomCompleto";
            this.lblNomCompleto.Size = new System.Drawing.Size(162, 24);
            this.lblNomCompleto.TabIndex = 11;
            this.lblNomCompleto.Text = "Nombre completo";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(286, 186);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(106, 24);
            this.lblContraseña.TabIndex = 10;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblNomUsuario
            // 
            this.lblNomUsuario.AutoSize = true;
            this.lblNomUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNomUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomUsuario.Location = new System.Drawing.Point(286, 140);
            this.lblNomUsuario.Name = "lblNomUsuario";
            this.lblNomUsuario.Size = new System.Drawing.Size(173, 24);
            this.lblNomUsuario.TabIndex = 9;
            this.lblNomUsuario.Text = "Nombre de usuario";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(276, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(148, 29);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Registrarse";
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoUsuario.FormattingEnabled = true;
            this.cbTipoUsuario.Location = new System.Drawing.Point(480, 231);
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.Size = new System.Drawing.Size(150, 24);
            this.cbTipoUsuario.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tipo Usuario";
            // 
            // frmRegistrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaEncomienda.Properties.Resources.ubuntu_nuevos_fondos_escritorio_wallpaper_predominan_siempre_7790;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 421);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTipoUsuario);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tbContraRegistro);
            this.Controls.Add(this.tbNomUsuarioRegistro);
            this.Controls.Add(this.tbNomCompletoRegistro);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.lblNomCompleto);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblNomUsuario);
            this.Controls.Add(this.pnlImagen);
            this.Name = "frmRegistrarse";
            this.Tag = "";
            this.Load += new System.EventHandler(this.frmRegistrarse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlImagen;
        private System.Windows.Forms.TextBox tbContraRegistro;
        private System.Windows.Forms.TextBox tbNomUsuarioRegistro;
        private System.Windows.Forms.TextBox tbNomCompletoRegistro;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Label lblNomCompleto;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblNomUsuario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cbTipoUsuario;
        private System.Windows.Forms.Label label1;
    }
}