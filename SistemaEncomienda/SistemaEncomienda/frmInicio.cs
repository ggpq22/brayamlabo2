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
                PermirCrearCuentaInicial();
                
            }
        }

  


        public void PermirCrearCuentaInicial()
        {
            List<clsUsuario> lista = new List<clsUsuario>();
            clsUsuario aux = new clsUsuario();
            string tipoUsuario = string.Empty;
            foreach (clsUsuario a in aux.Leer())
            {
                if (a != null)
                {
                    lista.Add(a);
                }
            }
            if (lista.Count != 0)
            {
                btnRegistrarse.Enabled = false;
            }
            else
            {
                btnRegistrarse.Enabled = true;
            }
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            PermirCrearCuentaInicial();
        }

   

 

      
    }
}
