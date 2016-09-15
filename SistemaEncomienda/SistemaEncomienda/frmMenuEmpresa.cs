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
namespace SistemaEncomienda
{
    public partial class frmMenuEmpresa : Form
    {
        string nombre;
        public frmMenuEmpresa(string nombre)
        {
            this.nombre = nombre;
            InitializeComponent();
        }

        private void frmMenuEmpresa_Load(object sender, EventArgs e)
        {
            List<clsFactura> lista = new List<clsFactura>();
            clsFactura aux = new clsFactura();
            lista = aux.traerFacturas(nombre);

            dgvEnviosRecibidos.DataSource = lista;

        }
    }
}
