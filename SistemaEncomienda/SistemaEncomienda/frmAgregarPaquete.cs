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
    public partial class frmAgregarPaquete : Form
    {
        clsArchivoBinario paquetitos = new clsArchivoBinario("C://prueba", "paquetes.dat");
        public frmAgregarPaquete()
        {
            InitializeComponent();
        }

        private void btnGrabarPaquete_Click(object sender, EventArgs e)
        {

           if (tbNomdestinatario.Text != string.Empty && tbDniDestinatario.Text != string.Empty && tbciudadCliente.Text != string.Empty && tbdirecDest.Text != string.Empty && tbKg.Text != string.Empty)
           { 
            clsPaquete nuevo = new clsPaquete();
            nuevo.Id = nuevo.RecuperarUltimoId() + 1;
            nuevo.NombreDestinatario = tbNomdestinatario.Text;
            nuevo.DniDestinatario = int.Parse(tbDniDestinatario.Text);
            nuevo.Ciudad = tbciudadCliente.Text;
            nuevo.Direccion = tbdirecDest.Text;
            nuevo.Kilos = float.Parse(tbKg.Text);
            nuevo.Estado = "Para enviar";
            nuevo.Codigo = "CDP" + nuevo.Id;

                string res = string.Empty;
                res = nuevo.Grabar();
                if (res == string.Empty)
                {
                    MessageBox.Show("Paquete registrado");
                }
                else { MessageBox.Show("ocurrio el siguiente error" + res); }
            }

            else { MessageBox.Show("Campos incompletos"); }
        }

        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            List<clsPaquete> lista = new List<clsPaquete>();
            clsPaquete aux = new clsPaquete();

            foreach (clsPaquete p in aux.Leer()) 
            {
                if (p.Estado == "Para enviar") 
                {
                    lista.Add(p);
                }
                
            }

            dgvAgregarPaquete.DataSource = null;
            dgvAgregarPaquete.DataSource = lista;
        }

        private void tbDniCliente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbNomdestinatario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }

            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }

            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmAgregarPaquete_Load(object sender, EventArgs e)
        {

        }
    }
}
