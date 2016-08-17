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
            clsPaquete aux = new clsPaquete();
            clsPaquete p= new clsPaquete();
            p=aux.retornarPaquete(codigo);
            if (codigo != string.Empty)
            {
                if (p.Codigo != null)
                {

                    frmEstadoPaquete frmEP = new frmEstadoPaquete(codigo);
                    frmEP.ShowDialog();
                }

                else { MessageBox.Show("codigo ingresado no es valido"); }
            }
            else
            {
                MessageBox.Show("Debe ingresar el codigo del paquete");
            }
        }
    }
}
