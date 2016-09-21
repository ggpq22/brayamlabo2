using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEncomienda
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            frmAgregarCliente c = new frmAgregarCliente();
            c.ShowDialog();
        }

        private void btnAgregarPaquete_Click(object sender, EventArgs e)
        {
            frmAgregarPaquete p = new frmAgregarPaquete();
            p.ShowDialog();
        }

        private void btnDespacharPaquete_Click(object sender, EventArgs e)
        {
            frmRegistrarEncomienda r = new frmRegistrarEncomienda();
            r.ShowDialog();
        }

        private void btnMostrarEncomiendas_Click(object sender, EventArgs e)
        {
            frmMostrarEnvios m = new frmMostrarEnvios();
            m.ShowDialog();
        }

        private void btnModificarEliminar_Click(object sender, EventArgs e)
        {
            frmModificarCliente n = new frmModificarCliente();
            n.ShowDialog();
        }

        private void btnAgregarUsuarios_Click(object sender, EventArgs e)
        {
            frmRegistrarse fr = new frmRegistrarse();
            fr.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            frmAgregarEmpresa ade = new frmAgregarEmpresa();
            ade.ShowDialog();
        }

        private void btnEstadistica_Click(object sender, EventArgs e)
        {
            frmEstadisticas fe = new frmEstadisticas();
            fe.ShowDialog();
        }
    }
}
