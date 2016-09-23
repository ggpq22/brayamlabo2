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
using System.Collections;
namespace SistemaEncomienda
{
    public partial class frmMostrarEnvios : Form
    {
        public frmMostrarEnvios()
        {
            InitializeComponent();
        }

        clsFactura en = new clsFactura();
        List<clsFactura> lista;

        private void frmMostrarVentas_Load(object sender, EventArgs e)
        {

            clsEmpresa nueva = new clsEmpresa();

            foreach (clsEmpresa a in nueva.Leer())
            {
                if (a != null)
                {
                    cbEmpresa.Items.Add(a.NombreEmpresa);
                }

            }

            cbEmpresa.Items.Add("Todas");
            cbEmpresa.SelectedItem = "Todas";

            dgvMostrar.DataSource = null;
            lista = new List<clsFactura>();
            foreach (clsFactura a in en.Leer()) 
            {
                lista.Add(a);
            }
            dgvMostrar.DataSource = lista;

            organizarDGV();

            dtpFiltroFechaEnvioDesde.Enabled = ckbFiltroFechaEnvioDesde.Checked;
            dtpFiltroFechaEnvioHasta.Enabled = ckbFiltroFechaEnvioHasta.Checked;
            
        }

        public void organizarDGV()
        {
            if (dgvMostrar.Rows.Count != 0)
            {
                dgvMostrar.Columns["Id"].Visible = false;
              

                dgvMostrar.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvMostrar.Columns["Dnicliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dgvMostrar.Columns["Nombrecliente"].HeaderText = "Nombre Cliente";
                dgvMostrar.Columns["Dnicliente"].HeaderText = "DNI Cliente";
                dgvMostrar.Columns["Fechaenvio"].HeaderText = "Fecha Envio";
                dgvMostrar.Columns["Empresa"].HeaderText = "Empresa";
                dgvMostrar.Columns["Precio"].HeaderText = "Precio $";
                dgvMostrar.Columns["CodigoPaquete"].HeaderText = "Codigo Paquete";
            }
        }

        public void filtros()
        {
            lista = new List<clsFactura>();
            dgvMostrar.DataSource = null;
            foreach (clsFactura a in en.Leer())
            {
                lista.Add(a);
            }
            dgvMostrar.DataSource = lista;
            organizarDGV();

            if (Convert.ToString(cbEmpresa.SelectedItem).CompareTo("Todas") != 0)
            {
                for (int i = 0; i < dgvMostrar.Rows.Count; i++)
                {
                    if (Convert.ToString(dgvMostrar.Rows[i].Cells["Empresa"].Value).CompareTo(Convert.ToString(cbEmpresa.SelectedItem)) != 0)
                    {
                        dgvMostrar.CurrentCell = null;
                        dgvMostrar.Rows[i].Visible = false;
                    }
                }
            }
            if (tbFiltroNombreCliente.Text != string.Empty)
            {
                for (int i = 0; i < dgvMostrar.Rows.Count; i++)
                {
                    if (tbFiltroNombreCliente.Text.Length > Convert.ToString(dgvMostrar.Rows[i].Cells["Nombrecliente"].Value).Length || Convert.ToString(dgvMostrar.Rows[i].Cells["Nombrecliente"].Value).Substring(0, tbFiltroNombreCliente.Text.Length).ToLower().CompareTo(tbFiltroNombreCliente.Text.ToLower()) != 0)
                    {
                        dgvMostrar.CurrentCell = null;
                        dgvMostrar.Rows[i].Visible = false;

                    }
                }
            }

            if (tbFiltroDniCliente.Text != string.Empty)
            {
                for (int i = 0; i < dgvMostrar.Rows.Count; i++)
                {
                    if (tbFiltroDniCliente.Text.Length > Convert.ToString(dgvMostrar.Rows[i].Cells["Dnicliente"].Value).Length || Convert.ToString(dgvMostrar.Rows[i].Cells["Dnicliente"].Value).Substring(0, tbFiltroDniCliente.Text.Length).ToLower().CompareTo(tbFiltroDniCliente.Text.ToLower()) != 0)
                    {
                        dgvMostrar.CurrentCell = null;
                        dgvMostrar.Rows[i].Visible = false;

                    }
                }
            }

            dtpFiltroFechaEnvioDesde.Enabled = ckbFiltroFechaEnvioDesde.Checked;
            dtpFiltroFechaEnvioHasta.Enabled = ckbFiltroFechaEnvioHasta.Checked;

            if ((ckbFiltroFechaEnvioDesde.Checked) && (ckbFiltroFechaEnvioHasta.Checked))
            {

                for (int i = 0; i < dgvMostrar.Rows.Count; i++)
                {
                    if ((Convert.ToDateTime(dgvMostrar.Rows[i].Cells["Fechaenvio"].Value).Date < Convert.ToDateTime(dtpFiltroFechaEnvioDesde.Value).Date) || (Convert.ToDateTime(dgvMostrar.Rows[i].Cells["Fechaenvio"].Value).Date > Convert.ToDateTime(dtpFiltroFechaEnvioHasta.Value).Date))
                    {
                        dgvMostrar.CurrentCell = null;
                        dgvMostrar.Rows[i].Visible = false;

                    }
                }

            }
            else if ((ckbFiltroFechaEnvioDesde.Checked) && (!ckbFiltroFechaEnvioHasta.Checked))
            {
                for (int i = 0; i < dgvMostrar.Rows.Count; i++)
                {
                    if ((Convert.ToDateTime(dgvMostrar.Rows[i].Cells["Fechaenvio"].Value).Date < Convert.ToDateTime(dtpFiltroFechaEnvioDesde.Value).Date))
                    {
                        dgvMostrar.CurrentCell = null;
                        dgvMostrar.Rows[i].Visible = false;

                    }
                }
            }
            else if ((!ckbFiltroFechaEnvioDesde.Checked) && (ckbFiltroFechaEnvioHasta.Checked))
            {
                for (int i = 0; i < dgvMostrar.Rows.Count; i++)
                {
                    if ((Convert.ToDateTime(dgvMostrar.Rows[i].Cells["Fechaenvio"].Value).Date > Convert.ToDateTime(dtpFiltroFechaEnvioHasta.Value).Date))
                    {
                        dgvMostrar.CurrentCell = null;
                        dgvMostrar.Rows[i].Visible = false;

                    }
                }
            }

            int indice = 0;
            bool continuar = false;
            while (indice < dgvMostrar.Rows.Count && !continuar)
            {
                if (dgvMostrar.Rows[indice].Visible)
                {
                    dgvMostrar.Rows[indice].Selected = true;
                    continuar = true;
                }
                indice++;
            }

        
        }

        private void cbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtros();
        }

        private void tbFiltroDniCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }



 

    
    }
}
