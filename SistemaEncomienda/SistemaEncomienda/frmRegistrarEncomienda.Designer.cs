namespace SistemaEncomienda
{
    partial class frmRegistrarEncomienda
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
            this.dgvElegirPaquete = new System.Windows.Forms.DataGridView();
            this.dgvElegircliente = new System.Windows.Forms.DataGridView();
            this.lblSleccion = new System.Windows.Forms.Label();
            this.lblSleccioncliente = new System.Windows.Forms.Label();
            this.tbCodpaquete = new System.Windows.Forms.TextBox();
            this.tbnomcliente = new System.Windows.Forms.TextBox();
            this.tbdnicliente = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.cbempresas = new System.Windows.Forms.ComboBox();
            this.lblNropaquete = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegistrarEncomienda = new System.Windows.Forms.Button();
            this.lblAgcliente = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCodPostal = new System.Windows.Forms.TextBox();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.dtOculto = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElegirPaquete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElegircliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvElegirPaquete
            // 
            this.dgvElegirPaquete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElegirPaquete.Location = new System.Drawing.Point(12, 77);
            this.dgvElegirPaquete.Name = "dgvElegirPaquete";
            this.dgvElegirPaquete.ReadOnly = true;
            this.dgvElegirPaquete.Size = new System.Drawing.Size(547, 150);
            this.dgvElegirPaquete.TabIndex = 0;
            this.dgvElegirPaquete.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvElegirPaquete_CellContentClick);
            this.dgvElegirPaquete.Click += new System.EventHandler(this.dgvElegirPaquete_Click);
            // 
            // dgvElegircliente
            // 
            this.dgvElegircliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElegircliente.Location = new System.Drawing.Point(603, 77);
            this.dgvElegircliente.Name = "dgvElegircliente";
            this.dgvElegircliente.ReadOnly = true;
            this.dgvElegircliente.Size = new System.Drawing.Size(547, 150);
            this.dgvElegircliente.TabIndex = 1;
            this.dgvElegircliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvElegircliente_CellContentClick);
            this.dgvElegircliente.Click += new System.EventHandler(this.dgvElegircliente_Click);
            // 
            // lblSleccion
            // 
            this.lblSleccion.AutoSize = true;
            this.lblSleccion.BackColor = System.Drawing.Color.Black;
            this.lblSleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSleccion.ForeColor = System.Drawing.Color.Yellow;
            this.lblSleccion.Location = new System.Drawing.Point(107, 18);
            this.lblSleccion.Name = "lblSleccion";
            this.lblSleccion.Size = new System.Drawing.Size(413, 31);
            this.lblSleccion.TabIndex = 2;
            this.lblSleccion.Text = "Seleccione el paquete a enviar";
            // 
            // lblSleccioncliente
            // 
            this.lblSleccioncliente.AutoSize = true;
            this.lblSleccioncliente.BackColor = System.Drawing.Color.Black;
            this.lblSleccioncliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSleccioncliente.ForeColor = System.Drawing.Color.Yellow;
            this.lblSleccioncliente.Location = new System.Drawing.Point(734, 18);
            this.lblSleccioncliente.Name = "lblSleccioncliente";
            this.lblSleccioncliente.Size = new System.Drawing.Size(282, 31);
            this.lblSleccioncliente.TabIndex = 3;
            this.lblSleccioncliente.Text = "Seleccione el cliente";
            // 
            // tbCodpaquete
            // 
            this.tbCodpaquete.Location = new System.Drawing.Point(417, 250);
            this.tbCodpaquete.Multiline = true;
            this.tbCodpaquete.Name = "tbCodpaquete";
            this.tbCodpaquete.Size = new System.Drawing.Size(142, 30);
            this.tbCodpaquete.TabIndex = 4;
            // 
            // tbnomcliente
            // 
            this.tbnomcliente.Location = new System.Drawing.Point(417, 302);
            this.tbnomcliente.Multiline = true;
            this.tbnomcliente.Name = "tbnomcliente";
            this.tbnomcliente.Size = new System.Drawing.Size(142, 30);
            this.tbnomcliente.TabIndex = 5;
            // 
            // tbdnicliente
            // 
            this.tbdnicliente.Location = new System.Drawing.Point(417, 354);
            this.tbdnicliente.Multiline = true;
            this.tbdnicliente.Name = "tbdnicliente";
            this.tbdnicliente.Size = new System.Drawing.Size(142, 30);
            this.tbdnicliente.TabIndex = 6;
            this.tbdnicliente.Click += new System.EventHandler(this.tbdnicliente_Click);
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(417, 400);
            this.tbPrecio.Multiline = true;
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(142, 30);
            this.tbPrecio.TabIndex = 7;
            // 
            // cbempresas
            // 
            this.cbempresas.FormattingEnabled = true;
            this.cbempresas.Location = new System.Drawing.Point(417, 543);
            this.cbempresas.Name = "cbempresas";
            this.cbempresas.Size = new System.Drawing.Size(121, 21);
            this.cbempresas.TabIndex = 9;
            // 
            // lblNropaquete
            // 
            this.lblNropaquete.AutoSize = true;
            this.lblNropaquete.BackColor = System.Drawing.Color.Black;
            this.lblNropaquete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNropaquete.ForeColor = System.Drawing.Color.White;
            this.lblNropaquete.Location = new System.Drawing.Point(223, 250);
            this.lblNropaquete.Name = "lblNropaquete";
            this.lblNropaquete.Size = new System.Drawing.Size(188, 29);
            this.lblNropaquete.TabIndex = 10;
            this.lblNropaquete.Text = "Codigo Paquete";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(233, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(233, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Dni cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(233, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(233, 493);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fecha ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(233, 535);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Empresa";
            // 
            // btnRegistrarEncomienda
            // 
            this.btnRegistrarEncomienda.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarEncomienda.BackgroundImage = global::SistemaEncomienda.Properties.Resources.Entypo_e722_0__256;
            this.btnRegistrarEncomienda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrarEncomienda.FlatAppearance.BorderSize = 0;
            this.btnRegistrarEncomienda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarEncomienda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarEncomienda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarEncomienda.Location = new System.Drawing.Point(679, 457);
            this.btnRegistrarEncomienda.Name = "btnRegistrarEncomienda";
            this.btnRegistrarEncomienda.Size = new System.Drawing.Size(133, 109);
            this.btnRegistrarEncomienda.TabIndex = 16;
            this.btnRegistrarEncomienda.UseVisualStyleBackColor = false;
            this.btnRegistrarEncomienda.Click += new System.EventHandler(this.btnRegistrarEncomienda_Click);
            // 
            // lblAgcliente
            // 
            this.lblAgcliente.AutoSize = true;
            this.lblAgcliente.BackColor = System.Drawing.Color.Black;
            this.lblAgcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgcliente.ForeColor = System.Drawing.Color.White;
            this.lblAgcliente.Location = new System.Drawing.Point(778, 230);
            this.lblAgcliente.Name = "lblAgcliente";
            this.lblAgcliente.Size = new System.Drawing.Size(247, 24);
            this.lblAgcliente.TabIndex = 17;
            this.lblAgcliente.Text = "Agregar un nuevo cliente";
            this.lblAgcliente.Click += new System.EventHandler(this.lblAgcliente_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(233, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "Cod Postal";
            // 
            // tbCodPostal
            // 
            this.tbCodPostal.Location = new System.Drawing.Point(417, 445);
            this.tbCodPostal.Multiline = true;
            this.tbCodPostal.Name = "tbCodPostal";
            this.tbCodPostal.Size = new System.Drawing.Size(142, 30);
            this.tbCodPostal.TabIndex = 18;
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(417, 499);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(200, 20);
            this.dtpfecha.TabIndex = 8;
            // 
            // dtOculto
            // 
            this.dtOculto.Location = new System.Drawing.Point(465, -5);
            this.dtOculto.Name = "dtOculto";
            this.dtOculto.Size = new System.Drawing.Size(200, 20);
            this.dtOculto.TabIndex = 20;
            this.dtOculto.Visible = false;
            // 
            // frmRegistrarEncomienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaEncomienda.Properties.Resources.Fondos_de_Pantalla_Gratis_Abstractos__164_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1160, 574);
            this.Controls.Add(this.dtOculto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCodPostal);
            this.Controls.Add(this.lblAgcliente);
            this.Controls.Add(this.btnRegistrarEncomienda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNropaquete);
            this.Controls.Add(this.cbempresas);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbdnicliente);
            this.Controls.Add(this.tbnomcliente);
            this.Controls.Add(this.tbCodpaquete);
            this.Controls.Add(this.lblSleccioncliente);
            this.Controls.Add(this.lblSleccion);
            this.Controls.Add(this.dgvElegircliente);
            this.Controls.Add(this.dgvElegirPaquete);
            this.Name = "frmRegistrarEncomienda";
            this.Load += new System.EventHandler(this.frmRegistrarEncomienda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvElegirPaquete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElegircliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvElegirPaquete;
        private System.Windows.Forms.DataGridView dgvElegircliente;
        private System.Windows.Forms.Label lblSleccion;
        private System.Windows.Forms.Label lblSleccioncliente;
        private System.Windows.Forms.TextBox tbCodpaquete;
        private System.Windows.Forms.TextBox tbnomcliente;
        private System.Windows.Forms.TextBox tbdnicliente;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.ComboBox cbempresas;
        private System.Windows.Forms.Label lblNropaquete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegistrarEncomienda;
        private System.Windows.Forms.Label lblAgcliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCodPostal;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.DateTimePicker dtOculto;
    }
}