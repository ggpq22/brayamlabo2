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
    public partial class frmLibre : Form
    {
        public frmLibre()
        {
            InitializeComponent();
        }

        private void btnRastrear_Click(object sender, EventArgs e)
        {
            frmRastrearPaquete nuevo = new frmRastrearPaquete();
            nuevo.ShowDialog();
        }

        private void btnVerMisenvios_Click(object sender, EventArgs e)
        {
            frmMisenvios me = new frmMisenvios();
            me.ShowDialog();
        }
    }
}
