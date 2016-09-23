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
    public partial class frmEmpresaMenuPrincipal : Form
    {
        string nombre;
        public frmEmpresaMenuPrincipal(string nombre)
        {
            InitializeComponent();
            this.nombre = nombre;
        }

        private void btnAgregarSucursal_Click(object sender, EventArgs e)
        {
            frmAgregarSucursal s = new frmAgregarSucursal(nombre);
            s.ShowDialog();
        }

        private void btnPaquetes_Click(object sender, EventArgs e)
        {
            frmMenuEmpresa f = new frmMenuEmpresa(nombre);
            f.ShowDialog();
        }
    }
}
