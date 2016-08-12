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
    public partial class frmEstadoPaquete : Form
    {

        string codigo;

        public frmEstadoPaquete(string codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
        }
    }
}
