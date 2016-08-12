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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Tag.ToString() == "1") 
            {
                frmLogin log = new frmLogin();
                this.Visible = false;
                log.ShowDialog();
                this.Visible = true;
            }

            else if ((sender as Button).Tag.ToString() == "2") 
            {
                frmRegistrarse reg = new frmRegistrarse();
                reg.ShowDialog();
                
            }
        }
    }
}
