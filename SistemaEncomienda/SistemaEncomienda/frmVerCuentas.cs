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
using System.Collections;
namespace SistemaEncomienda
{
    public partial class frmVerCuentas : Form
    {
        public frmVerCuentas()
        {
            InitializeComponent();
        }

        private void frmVerCuentas_Load(object sender, EventArgs e)
        {
            clsUsuario cuentas = new clsUsuario();
           
            List<clsUsuario> lista = new List<clsUsuario>();
            foreach (clsUsuario a in cuentas.Leer()) 
            {
                lista.Add(a);
            }

            if (lista != null) 
            {
                dgvMostrarCuentas.DataSource = null;
                dgvMostrarCuentas.DataSource = lista;
            }
        }
    }
}
