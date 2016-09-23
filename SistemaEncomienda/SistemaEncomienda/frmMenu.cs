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

        ToolTip t = new ToolTip();
        ToolTip t1 = new ToolTip();
        ToolTip t2 = new ToolTip();
        ToolTip t3 = new ToolTip();
        ToolTip t4 = new ToolTip();
        ToolTip t5 = new ToolTip();
        ToolTip t6 = new ToolTip();
        ToolTip t7 = new ToolTip();
        ToolTip t8 = new ToolTip();
        private void btnAgregarCliente_MouseHover(object sender, EventArgs e)
        {
            t.Show("Agregar Cliente",btnAgregarCliente);
        }

        private void btnEstadistica_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Estadisticas", btnEstadistica);
        }

        private void btnAgregarEmpresa_MouseHover(object sender, EventArgs e)
        {
            t2.Show("Agregar Empresa",btnAgregarEmpresa);
        }

        private void btnMostrarEncomiendas_MouseHover(object sender, EventArgs e)
        {
            t3.Show("Ver envios",btnMostrarEncomiendas);
        }

        private void btnDespacharPaquete_MouseHover(object sender, EventArgs e)
        {
            t4.Show("Registrar Encomienda",btnDespacharPaquete);
        }

        private void btnAgregarPaquete_MouseHover(object sender, EventArgs e)
        {
            t5.Show("Registrar paquete",btnAgregarPaquete);
        }

        private void btnModificarEliminar_MouseHover(object sender, EventArgs e)
        {
            t6.Show("Modificar cliente",btnModificarEliminar);
        }

        private void btnVerUsuarios_Click(object sender, EventArgs e)
        {
            frmVerCuentas f = new frmVerCuentas();
            f.ShowDialog();
        }

        private void btnVerUsuarios_MouseHover(object sender, EventArgs e)
        {
            t7.Show("Ver cuentas",btnVerUsuarios);
        }

        private void btnAgregarUsuarios_MouseHover(object sender, EventArgs e)
        {
            t8.Show("Agregar Usuario",btnAgregarUsuarios);
        }
    }
}
