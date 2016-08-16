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

namespace SistemaEncomienda
{
    public partial class frmEstadoPaquete : Form
    {

        string codigo;
        clsPaquete p1 = new clsPaquete();
        clsFactura f1 = new clsFactura();
        public frmEstadoPaquete(string codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmEstadoPaquete_Load(object sender, EventArgs e)
        {
            clsPaquete aux = new clsPaquete();
            aux=p1.retornarPaquete(codigo);
            clsFactura fac = new clsFactura();
            fac = f1.recuperarFac(codigo);
            if (aux != null && fac != null) 
            {
                lblEstado.Text = aux.Estado;
                lblNombreCliente.Text = f1.Nombrecliente;
                lblDniCliente.Text = f1.Dnicliente.ToString();
                lblCiudad.Text = aux.Ciudad;
                lblDireccion.Text = aux.Direccion;
                lblEmpresa.Text = f1.Empresa;
                lblFecEnvio.Text = f1.Fechaenvio.ToString();


            }

            else { MessageBox.Show("Codigo invalido, por favor verifique el codigo"); }
        }
    }
}
