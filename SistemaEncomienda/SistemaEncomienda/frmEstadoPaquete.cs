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
          

            dgvMostrar.Columns.Add("Nombre Cliente","Nombre Cliente");
            dgvMostrar.Columns.Add("DNI","DNI");
            dgvMostrar.Columns.Add("Fecha Envio","Fecha Envio");
            dgvMostrar.Columns.Add("Empresa","Empresa");
            dgvMostrar.Columns.Add("Destino","Destino");
            dgvMostrar.Columns.Add("Direccion", "Direccion");
            dgvMostrar.Columns.Add("Estado", "Estado");
            dgvMostrar.Columns.Add("fechallegada","fechallegada");
            cargarDgv();
            lblEstado.Text = "Estado:" + dgvMostrar.Rows[dgvMostrar.Rows.Count - 1].Cells["Estado"].Value.ToString();
        }

        private void cargarDgv() 
        {
            clsPaquete aux = new clsPaquete();
            aux = p1.retornarPaquete(codigo);
            clsFactura fac = new clsFactura();
            fac = f1.recuperarFac(codigo);
            if (aux != null && fac != null) 
            {
                dgvMostrar.Rows[dgvMostrar.Rows.Count - 1].Cells["Nombre Cliente"].Value = fac.Nombrecliente;
                dgvMostrar.Rows[dgvMostrar.Rows.Count - 1].Cells["DNI"].Value = fac.Dnicliente;
                dgvMostrar.Rows[dgvMostrar.Rows.Count - 1].Cells["Fecha Envio"].Value = fac.Fechaenvio;
                dgvMostrar.Rows[dgvMostrar.Rows.Count - 1].Cells["Empresa"].Value = fac.Empresa;
                dgvMostrar.Rows[dgvMostrar.Rows.Count - 1].Cells["Destino"].Value =aux.Ciudad;
                dgvMostrar.Rows[dgvMostrar.Rows.Count - 1].Cells["Direccion"].Value = aux.Direccion;
                dgvMostrar.Rows[dgvMostrar.Rows.Count - 1].Cells["Estado"].Value = aux.Estado;
                dgvMostrar.Rows[dgvMostrar.Rows.Count - 1].Cells["fechallegada"].Value = fac.Fechallegada;

                
                

            }

            else { MessageBox.Show("Codigo invalido, verifique los datos"); }
        }

    }
}
