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

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsUsuario usuarioEmpresa = new clsUsuario();
            clsEmpresa nuevaEmpresa = new clsEmpresa();
            string res1 = string.Empty;
            string res2 = string.Empty;
            if (tbNomEmpresa.Text != string.Empty && tbDireccionEmpresa.Text != string.Empty && tbCiudad.Text != string.Empty && tbTelefono.Text != string.Empty && tbCodP.Text!=string.Empty)
            {
                nuevaEmpresa.NombreEmpresa = tbNomEmpresa.Text;
                nuevaEmpresa.Direccion = tbDireccionEmpresa.Text;
                nuevaEmpresa.Telefono = tbTelefono.Text;
                nuevaEmpresa.CiudadUbicacion = tbCiudad.Text;
                nuevaEmpresa.CodPostal =int.Parse(tbCodP.Text);
                nuevaEmpresa.Id = nuevaEmpresa.RecuperarUltimoId();
                res1 = nuevaEmpresa.Grabar();
                usuarioEmpresa.Nombre = tbNomEmpresa.Text;
                usuarioEmpresa.Usuario = tbNomEmpresa.Text;
                usuarioEmpresa.Contraseña = "1234";
                usuarioEmpresa.TipoUsuario = "Empresa";
                res2 = usuarioEmpresa.Grabar();

                if (res1 == string.Empty && res2 == string.Empty)
                {
                    MessageBox.Show("Empresa registrada con exito el usuario para ingresar al sistema es: " + usuarioEmpresa.Usuario + " y la contraseña: " + usuarioEmpresa.Contraseña);
                }
                else { MessageBox.Show("ocurrio el siguiente error" + res1 + res2); }
            }
            else { MessageBox.Show("Campos incompleto, por favor ingrese todos los datos solicitados"); }
        }
    }
}
