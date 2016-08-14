using System;
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


namespace SistemaEncomienda
{
    public partial class frmRegistrarse : Form
    {
        clsArchivoBinario ad = new clsArchivoBinario("C://prueba","administrador.dat");
        public frmRegistrarse()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            bool encontrado=false;
            clsUsuario nuevo = new clsUsuario();
            nuevo.Nombre = tbNomCompletoRegistro.Text;
            nuevo.Usuario = tbNomUsuarioRegistro.Text;
            nuevo.Contraseña = tbContraRegistro.Text;
            nuevo.TipoUsuario = cbTipoUsuario.SelectedItem.ToString();

            if (tbNomCompletoRegistro.Text != string.Empty && tbNomUsuarioRegistro.Text != string.Empty && tbContraRegistro.Text != string.Empty)
            {
                string res = string.Empty;
                List<clsUsuario> lista = new List<clsUsuario>();
                clsUsuario aux = new clsUsuario();
                foreach (clsUsuario a in aux.Leer())
                {
                    lista.Add(a);
                }
                foreach (clsUsuario b in lista)
                {
                    if (b != null)
                    {
                        if (tbNomUsuarioRegistro.Text == b.Usuario)
                        {
                            encontrado = true;
                        }
                    }
                }
                if (encontrado == true)
                {
                    MessageBox.Show("ya existe un usuario con ese nombre");
                }

                else
                {
                    res = nuevo.Grabar();
                    if (res == string.Empty)
                    {
                        MessageBox.Show("Usuario registrado");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio el siguiente error" + res);
                    }

                }
            }

            else 
            { 
                MessageBox.Show("Campos incompletos"); 
            }

        }

        private void frmRegistrarse_Load(object sender, EventArgs e)
        {
            cbTipoUsuario.Items.Add("Administrador");
            cbTipoUsuario.Items.Add("Empresa");
            cbTipoUsuario.Items.Add("Cliente");
            cbTipoUsuario.SelectedItem = "Administrador";

            List<clsUsuario> lista = new List<clsUsuario>();
            clsUsuario aux = new clsUsuario();
            foreach (clsUsuario a in aux.Leer())
            {
                if (a != null)
                {
                    lista.Add(a);
                }
            }
            if(lista.Count == 0)
            {
                cbTipoUsuario.Enabled = false;
            }

            
        }

        private void tbNomCompletoRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }

            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }

            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}
