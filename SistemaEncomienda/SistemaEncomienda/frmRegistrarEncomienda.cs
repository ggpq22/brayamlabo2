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
    public partial class frmRegistrarEncomienda : Form
    {
        public frmRegistrarEncomienda()
        {
            InitializeComponent();
        }

        private void lblAgcliente_Click(object sender, EventArgs e)
        {
            frmAgregarCliente n = new frmAgregarCliente();
            n.ShowDialog();
        }

        private void frmRegistrarEncomienda_Load(object sender, EventArgs e)
        {
            

            dgvElegircliente.DataSource = null;
            dgvElegirPaquete.DataSource = null;

            List<clsCliente> listaclientes = new List<clsCliente>();
            List<clsPaquete> listapaquetes = new List<clsPaquete>();
            clsPaquete p1 = new clsPaquete();
            clsCliente c1 = new clsCliente();

            foreach (clsCliente cli in c1.Leer()) 
            {
                if (cli.Estado == true)
                {
                    listaclientes.Add(cli);
                }
            }

            foreach (clsPaquete paq in p1.Leer()) 
            {
                if (paq.Estado == "Para enviar")
                {
                    listapaquetes.Add(paq);
                }
                
            }

            dgvElegircliente.DataSource = listaclientes;
            dgvElegirPaquete.DataSource = listapaquetes;

            clsEmpresa nueva = new clsEmpresa();
            foreach (clsEmpresa c in nueva.Leer()) 
            {
                if (c != null)
                {
                    cbempresas.Items.Add(c.NombreEmpresa);
                }
            }

           
            
        }

        private void dgvElegirPaquete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           

        }

        private void dgvElegircliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tbdnicliente_Click(object sender, EventArgs e)
        {

        }

        private void dgvElegirPaquete_Click(object sender, EventArgs e)
        {
            float resultado =float.Parse(dgvElegirPaquete.CurrentRow.Cells["Kilos"].Value.ToString())*10;
            tbCodpaquete.Text = dgvElegirPaquete.CurrentRow.Cells["Codigo"].Value.ToString();
            tbPrecio.Text = resultado.ToString();
            tbCodPostal.Text = dgvElegirPaquete.CurrentRow.Cells["codigoPostal"].Value.ToString();
           
        }

        private void dgvElegircliente_Click(object sender, EventArgs e)
        {
            tbnomcliente.Text = dgvElegircliente.CurrentRow.Cells["Nombre"].Value.ToString();
            tbdnicliente.Text = dgvElegircliente.CurrentRow.Cells["Dni"].Value.ToString();
        }

        private void btnRegistrarEncomienda_Click(object sender, EventArgs e)
        {

            if (tbCodpaquete.Text != string.Empty && tbdnicliente.Text != string.Empty && cbempresas.SelectedItem != null)
            {
                clsEmpresa verifica = new clsEmpresa();
                bool encontrado = verifica.existeCodigoPostal(cbempresas.SelectedItem.ToString(), int.Parse(tbCodPostal.Text));
                if (encontrado == true)
                {
                    clsFactura nuevo = new clsFactura();
                    nuevo.Id = nuevo.RecuperarUltimoId() + 1;
                    nuevo.CodigoPaquete = tbCodpaquete.Text;
                    nuevo.Nombrecliente = tbnomcliente.Text;
                    nuevo.Dnicliente = int.Parse(tbdnicliente.Text);
                    nuevo.Precio = float.Parse(tbPrecio.Text);
                    nuevo.Fechallegada = dtpfecha.Value;
                    nuevo.Fechaenvio = dtOculto.Value;
                    nuevo.Empresa = cbempresas.SelectedItem.ToString();
                    nuevo.Postal = int.Parse(tbCodPostal.Text);
                    List<clsPaquete> lista1 = new List<clsPaquete>();
                    clsPaquete cambiar = new clsPaquete();
                    cambiar = cambiar.retornarPaquete(nuevo.CodigoPaquete);
                    clsPaquete modi = new clsPaquete();
                    if (cambiar.Estado == "Despachado")
                    {
                        MessageBox.Show("Este paquete ya fue enviado");
                    }

                    else
                    {
                        clsPaquete p2 = new clsPaquete();

                        foreach (clsPaquete g in p2.Leer())
                        {
                            if (g.Id == cambiar.Id)
                            {
                                g.NombreDestinatario = cambiar.NombreDestinatario;
                                g.DniDestinatario = cambiar.DniDestinatario;
                                g.Ciudad = cambiar.Ciudad;
                                g.Direccion = cambiar.Direccion;
                                g.Id = cambiar.Id;
                                g.Codigo = cambiar.Codigo;
                                g.Kilos = cambiar.Kilos;
                                g.Estado = "Despachado";
                                lista1.Add(g);
                            }
                            else { lista1.Add(g); }
                        }



                        string res2 = string.Empty;
                        res2 = modi.ModificarPaq(lista1);
                        string res = string.Empty;
                        res = nuevo.Grabar();
                        if (res == string.Empty)
                        {
                            MessageBox.Show("encomienda enviada");
                        }

                        else { MessageBox.Show("ocurrio el siguiente error" + res); }

                        tbCodpaquete.Clear();
                        tbdnicliente.Clear();
                        tbnomcliente.Clear();
                        tbPrecio.Clear();
                    }
                }
                else { MessageBox.Show("No coincide el codigo postal del paquete con el de la empresa y sus sucursales, por favor verifique bien"); }
            }
            else if (tbCodpaquete.Text != string.Empty && tbdnicliente.Text == string.Empty && tbCodPostal.Text==string.Empty)
            {
                MessageBox.Show("Seleccione el cliente");
            }
            else { MessageBox.Show("Seleccione el paquete a enviar  "); }
        }
    }
}
