﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using misClases;
using claseArchivo;
using System.Collections;
namespace SistemaEncomienda
{
    public partial class frmLogin : Form
    {
        clsArchivoBinario adm = new clsArchivoBinario("C://prueba","administrador.dat");
        public frmLogin()
        {
            InitializeComponent();
        }

        private void tbusuarioLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblCliente.Visible = false;
            cbUsuarios.Items.Add("Administrador");
            cbUsuarios.Items.Add("Empresa");
            cbUsuarios.Items.Add("Cliente");
        }


        private void btnIngresarLogin_Click(object sender, EventArgs e)
        {
            List<clsUsuario> lista = new List<clsUsuario>();
            clsUsuario aux = new clsUsuario();
            string tipoUsuario = string.Empty;
            bool res = false;
            
            foreach (clsUsuario a in aux.Leer()) 
            {
                if (a != null)
                {
                    lista.Add(a);
                }
            }

        /*    if ( usuario.CompareTo("Cliente")==0) 
            {
                frmLibre fl = new frmLibre();
                fl.ShowDialog();

            }*/
            
            if (tbContraIngresar.Text != string.Empty && tbUsuIngresar.Text!=string.Empty)
            {

           
                foreach (clsUsuario b in lista)
                {
                    if ((b.Usuario == tbUsuIngresar.Text) && (b.Contraseña == tbContraIngresar.Text))
                    {
                        res = true;
                        tipoUsuario = b.TipoUsuario;
                    }
                }

                if (res == true)
                {
                    if (tipoUsuario.CompareTo("Administrador") == 0)
                    {
                        frmMenu m = new frmMenu();
                        m.ShowDialog();
                    }
                    else if (tipoUsuario.CompareTo("Empresa") == 0)
                    {
                        frmMenuEmpresa me = new frmMenuEmpresa();
                        me.ShowDialog();
                    }

                   

                }
                else { MessageBox.Show("Verifique sus datos"); }
            }

            else { MessageBox.Show("Complete los campos"); }
          
            
            tbContraIngresar.Clear();
            tbUsuIngresar.Clear();
        }

        private void cbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCliente.Visible = true;
            if (cbUsuarios.SelectedItem == "Cliente")
            {
                tbContraIngresar.Enabled = true;
                tbUsuIngresar.Enabled = true;

            }
        }
    }
}
