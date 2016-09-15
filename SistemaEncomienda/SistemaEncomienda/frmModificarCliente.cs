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
    public partial class frmModificarCliente : Form
    {
        clsArchivoBinario cliente = new clsArchivoBinario("C://prueba", "clientes.dat");
        public frmModificarCliente()
        {
            InitializeComponent();
        }

        private void frmModificarUsuario_Load(object sender, EventArgs e)
        {
            dgvModificar.DataSource = null;
            List<clsCliente> lista = new List<clsCliente>();
            clsCliente aux = new clsCliente();
            foreach(clsCliente a in aux.Leer())
            {
                lista.Add(a);
            }

            dgvModificar.DataSource = lista;
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            tbDniCliente.Enabled = false;
            tbNomCliente.Enabled = false;
            tbApellidoCliente.Enabled = false;
            clsCliente modificar = new clsCliente();
            modificar.Nombre=tbNomCliente.Text;
            modificar.Apellido=tbApellidoCliente.Text;
            modificar.Dni=int.Parse(tbDniCliente.Text);
            modificar.Direccion=tbDireccionCliente.Text;
            modificar.Email=tbEmailcliente.Text;
            modificar.Telefono=int.Parse(tbTelefono.Text);
            modificar.Estado=true;
            List<clsCliente> lista = new List<clsCliente>();
            clsCliente aux = new clsCliente();
            foreach (clsCliente c in aux.Leer()) 
            {
                if (c.Dni == modificar.Dni) 
                {
                    c.Nombre = modificar.Nombre;
                    c.Apellido = modificar.Apellido;
                    c.Dni = modificar.Dni;
                    c.Direccion = modificar.Direccion;
                    c.Telefono = modificar.Telefono;
                    c.Email = modificar.Email;
                    c.Estado = modificar.Estado;
                    lista.Add(c);
                }

                else { lista.Add(c); }
            }

            string res = string.Empty;
            res=modificar.Modificar(lista);
            if (res == string.Empty) 
            {
                MessageBox.Show("Cliente modificado con exito");
                dgvModificar.DataSource = lista;
            }

            else { MessageBox.Show("Ocurrio el siguiente error" + res); }

        }

        private void dgvModificar_Click(object sender, EventArgs e)
        {
            tbNomCliente.Text = dgvModificar.CurrentRow.Cells["Nombre"].Value.ToString();
            tbApellidoCliente.Text = dgvModificar.CurrentRow.Cells["Apellido"].Value.ToString();
            tbDniCliente.Text = dgvModificar.CurrentRow.Cells["Dni"].Value.ToString();
            tbDireccionCliente.Text = dgvModificar.CurrentRow.Cells["Direccion"].Value.ToString();
            tbEmailcliente.Text = dgvModificar.CurrentRow.Cells["Email"].Value.ToString();
            tbTelefono.Text = dgvModificar.CurrentRow.Cells["Telefono"].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            tbDniCliente.Enabled = false;
            tbNomCliente.Enabled = false;
            tbApellidoCliente.Enabled = false;
           

            if (tbApellidoCliente.Text != string.Empty && tbNomCliente.Text != string.Empty)
            {
                clsCliente eliminar = new clsCliente();
                eliminar.Nombre = tbNomCliente.Text;
                eliminar.Apellido = tbApellidoCliente.Text;
                eliminar.Dni = int.Parse(tbDniCliente.Text);
                eliminar.Direccion = tbDireccionCliente.Text;
                eliminar.Email = tbEmailcliente.Text;
                eliminar.Telefono = int.Parse(tbTelefono.Text);
                eliminar.Estado = Convert.ToBoolean(dgvModificar.CurrentRow.Cells["estado"].Value);

                if (eliminar.Estado != false)
                {
                    List<clsCliente> lista = new List<clsCliente>();
                    clsCliente aux = new clsCliente();
                    foreach (clsCliente c in aux.Leer())
                    {
                        if (c.Dni == eliminar.Dni)
                        {
                            c.Nombre = eliminar.Nombre;
                            c.Apellido = eliminar.Apellido;
                            c.Dni = eliminar.Dni;
                            c.Direccion = eliminar.Direccion;
                            c.Telefono = eliminar.Telefono;
                            c.Email = eliminar.Email;
                            c.Estado = false;
                            lista.Add(c);
                        }

                        else { lista.Add(c); }
                    }

                    string res = string.Empty;
                    res = eliminar.Modificar(lista);
                    if (res == string.Empty)
                    {
                        MessageBox.Show("Se dio de baja al cliente");
                        dgvModificar.DataSource = lista;
                    }

                    else { MessageBox.Show("Ocurrio el siguiente error" + res); }
                }
                else { MessageBox.Show("Este cliente ya fue dado de baja"); }
            }
            else { MessageBox.Show("Seleccione un contacto"); }
            }

    }
}
