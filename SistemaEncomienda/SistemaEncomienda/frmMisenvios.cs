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
    public partial class frmMisenvios : Form
    {
        public frmMisenvios()
        {
            InitializeComponent();
        }

        private void btnMostrarInfo_Click(object sender, EventArgs e)
        {
            if (tbDniBuscar.Text != string.Empty)
            {
                clsFactura mostrar = new clsFactura();
                List<clsFactura> lista = new List<clsFactura>();
                lista = mostrar.recuperarFac(int.Parse(tbDniBuscar.Text));
                if (lista != null)
                {
                    dgvFacturas.DataSource = lista;
                }
                else { MessageBox.Show("no se encontro la informacion"); }
            }

            else { MessageBox.Show("Ingrese el dni"); }
        }

        private void dgvPaquetesEnviados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbDniBuscar_KeyPress(object sender, KeyPressEventArgs e)
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
