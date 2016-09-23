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
    public partial class frmAgregarEmpresa : Form
    {
        public frmAgregarEmpresa()
        {
            InitializeComponent();
        }

        private void frmAgregarEmpresa_Load(object sender, EventArgs e)
        {

           actualizarGrilla();

        }

       public void actualizarGrilla()
        {
            clsEmpresa nueva = new clsEmpresa();
            List<clsEmpresa> lista = new List<clsEmpresa>();

            foreach (clsEmpresa a in nueva.Leer())
            {
                if (a != null)
                {
                    lista.Add(a);
                }

            }

            if (lista != null)
            {
                dgvEmpresa.DataSource = null;
                dgvEmpresa.DataSource = lista;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsUsuario usuarioEmpresa = new clsUsuario();
            clsEmpresa nuevaEmpresa = new clsEmpresa();
            string res1 = string.Empty;
            string res2 = string.Empty;
            if (tbNomEmpresa.Text != string.Empty && tbDireccionEmpresa.Text != string.Empty && tbCiudad.Text != string.Empty && tbTelefono.Text != string.Empty && tbCodP.Text!=string.Empty)
            {
                nuevaEmpresa.Id = nuevaEmpresa.RecuperarUltimoId() + 1;
                nuevaEmpresa.CiudadUbicacion = tbCiudad.Text;
                nuevaEmpresa.NombreEmpresa = tbNomEmpresa.Text +" "+ tbCiudad.Text;
                nuevaEmpresa.Direccion = tbDireccionEmpresa.Text;
                nuevaEmpresa.Telefono = tbTelefono.Text;
                nuevaEmpresa.CodPostal =int.Parse(tbCodP.Text);
                
                res1 = nuevaEmpresa.Grabar();
                usuarioEmpresa.Nombre = nuevaEmpresa.NombreEmpresa;
                usuarioEmpresa.Usuario = nuevaEmpresa.NombreEmpresa;
                usuarioEmpresa.Contraseña = "1234";
                usuarioEmpresa.TipoUsuario = "Empresa";
                res2 = usuarioEmpresa.Grabar();

                if (res1 == string.Empty && res2 == string.Empty)
                {
                    actualizarGrilla();
                    MessageBox.Show("Empresa registrada con exito el usuario para ingresar al sistema es: " + usuarioEmpresa.Usuario + " y la contraseña: " + usuarioEmpresa.Contraseña);
                }
                else { MessageBox.Show("ocurrio el siguiente error" + res1 + res2); }
            }
            else { MessageBox.Show("Campos incompleto, por favor ingrese todos los datos solicitados"); }

            tbCiudad.Clear();
            tbCodP.Clear();
            tbDireccionEmpresa.Clear();
            tbNomEmpresa.Clear();
            tbTelefono.Clear();

        }

        private void tbNomEmpresa_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }

            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       
    }
}
