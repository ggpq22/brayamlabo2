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
    public partial class frmMenuCliente : Form
    {
        public frmMenuCliente()
        {
            InitializeComponent();
        }

        private void btnRastrear_Click(object sender, EventArgs e)
        {
            string codigo = tbCodigoAbuscar.Text;
            if(codigo != string.Empty)
            {
                frmEstadoPaquete frmEP = new frmEstadoPaquete(codigo);
                frmEP.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe ingresar el codigo del paquete");
            }
        }
    }
}
