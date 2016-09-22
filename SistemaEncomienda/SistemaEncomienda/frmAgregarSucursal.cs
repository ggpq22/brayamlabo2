using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using claseArchivo;
using misClases;
namespace SistemaEncomienda
{
    public partial class frmAgregarSucursal : Form
    {
        string nombre;
        public frmAgregarSucursal(string nombre)
        {
            InitializeComponent();
            this.nombre = nombre;
        }

        private void btnGrabarSucursal_Click(object sender, EventArgs e)
        {
            clsEmpresa c= new clsEmpresa();
            clsEmpresa c1= c.traerEmpresa(nombre);
            clsSucursal nueva = new clsSucursal();
            if (tbCodPostal.Text != string.Empty && tbDireccion.Text != string.Empty && tbProvincia.Text != string.Empty && tbLocalidad.Text != string.Empty && c1!= null)
            {
                nueva.IdSucursal = nueva.RecuperarUltimoId()+1;
                nueva.Nombre = "Sucursal " + nombre + " " + tbLocalidad.Text;
                nueva.LocalidadUbicacion = tbLocalidad.Text;
                nueva.Provincia = tbProvincia.Text;
                nueva.CodigoPostal = int.Parse(tbCodPostal.Text);
                nueva.Direccion = tbDireccion.Text;
                nueva.IdCentral = c1.Id;
                clsUsuario nuevo = new clsUsuario();
                nuevo.Nombre = nueva.Nombre;
                nuevo.Usuario = nueva.Nombre;
                nuevo.Contraseña = "1234";
                nuevo.TipoUsuario = "Sucursal";

                string resSucursal = string.Empty;
                string resUsuario = string.Empty;
                resSucursal = nueva.Grabar();
                resUsuario = nuevo.Grabar();
                if (resSucursal == string.Empty && resUsuario == string.Empty)
                {
                    MessageBox.Show("Sucursal registrada con exito el usuario para ingresar al sistema es: " + nuevo.Usuario + " y la contraseña: " + nuevo.Contraseña);
                }

                else { MessageBox.Show("Ocurrio el siguiente error: " + resSucursal + resUsuario); }

            }
            else { MessageBox.Show("Campos de datos incompletos"); }
        }

        private void frmAgregarSucursal_Load(object sender, EventArgs e)
        {

        }
    }
}
