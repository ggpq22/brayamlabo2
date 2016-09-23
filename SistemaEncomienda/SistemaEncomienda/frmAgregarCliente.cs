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
    public partial class frmAgregarCliente : Form
    {
        clsArchivoBinario clientito = new clsArchivoBinario("C://prueba", "clientes.dat");
        public frmAgregarCliente()
        {
            InitializeComponent();
        }
        
        private void btnGrabarCliente_Click(object sender, EventArgs e)
        {
            if (tbNomCliente.Text != string.Empty && tbApellidoCliente.Text != string.Empty && tbDniCliente.Text != string.Empty && tbTelefono.Text != string.Empty && tbEmailcliente.Text != string.Empty)
            {
                clsCliente nuevo = new clsCliente();
                nuevo.Nombre = tbNomCliente.Text;
               nuevo.Apellido = tbApellidoCliente.Text;
               nuevo.Dni = int.Parse(tbDniCliente.Text);
               nuevo.Direccion = tbDireccionCliente.Text;
               nuevo.Telefono = int.Parse(tbTelefono.Text);
               nuevo.Email = tbEmailcliente.Text;
               nuevo.Estado = true;
               nuevo.Ciudad = tbCiudadCliente.Text;
               string res = string.Empty;

            bool encontrado = false;
            
           
                List<clsCliente> lista = new List<clsCliente>();
                clsCliente aux = new clsCliente();
                foreach (clsCliente a in aux.Leer())
                {
                    lista.Add(a);
                }

                foreach (clsCliente b in lista)
                {
                    if (b.Dni == nuevo.Dni)
                    {
                        encontrado = true;
                    }
                }

                if (encontrado == true)
                {
                    MessageBox.Show("Este dni ya esta registrado");
                }

                else
                {
                    res = nuevo.Grabar();
                    if (res == string.Empty)
                    {
                        MessageBox.Show("Cliente registrado");
                    }

                    else { MessageBox.Show("Ocurrio el siguiente error" + res); }
                }
            }
            else { MessageBox.Show("Complete los campos por favor"); }

            tbApellidoCliente.Clear();
            tbCiudadCliente.Clear();
            tbDireccionCliente.Clear();
            tbDniCliente.Clear();
            tbEmailcliente.Clear();
            tbTelefono.Clear();
            tbNomCliente.Clear();
        }

        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            dgvAgregarCliente.DataSource = null;
            List<clsCliente> lista = new List<clsCliente>();
            clsCliente n = new clsCliente();
            foreach (clsCliente a in n.Leer()) 
            {
                if (a.Estado == true) 
                {
                    lista.Add(a);
                }
               
            }
            

             dgvAgregarCliente.DataSource = lista; 
        }

        private void tbNomCliente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frmAgregarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
