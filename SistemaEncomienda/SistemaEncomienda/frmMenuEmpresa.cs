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

            List<clsSucursal> listasucursal = new List<clsSucursal>();
            clsSucursal a = new clsSucursal();

            foreach (clsSucursal f in a.Leer()) 
            {
                listasucursal.Add(f);
            }

            dgvSucursal.DataSource = listasucursal;
        }

        private void btnRecibido_Click(object sender, EventArgs e)
        {
            clsEmpresa emp = new clsEmpresa();
            clsEmpresa aux = new clsEmpresa();
            emp=aux.traerEmpresa(nombre);
            if (dgvEnviosRecibidos.CurrentRow.Selected != true)
            {
                clsFactura fac = new clsFactura();

                fac.Id = int.Parse(dgvEnviosRecibidos.CurrentRow.Cells["id"].Value.ToString());
                fac.Nombrecliente = dgvEnviosRecibidos.CurrentRow.Cells["nombrecliente"].Value.ToString();
                fac.CodigoPaquete = dgvEnviosRecibidos.CurrentRow.Cells["codigoPaquete"].Value.ToString();
                fac.Dnicliente = int.Parse(dgvEnviosRecibidos.CurrentRow.Cells["dnicliente"].Value.ToString());
                fac.Empresa = dgvEnviosRecibidos.CurrentRow.Cells["empresa"].Value.ToString();
                fac.Fechaenvio = Convert.ToDateTime(dgvEnviosRecibidos.CurrentRow.Cells["fechaenvio"].Value.ToString());
                fac.Fechallegada = Convert.ToDateTime(dgvEnviosRecibidos.CurrentRow.Cells["fechallegada"].Value.ToString());
                fac.Postal = int.Parse(dgvEnviosRecibidos.CurrentRow.Cells["Postal"].Value.ToString());
                fac.Precio = float.Parse(dgvEnviosRecibidos.CurrentRow.Cells["precio"].Value.ToString());


                List<clsPaquete> lista1 = new List<clsPaquete>();
                clsPaquete cambiar = new clsPaquete();
                cambiar = cambiar.retornarPaquete(fac.CodigoPaquete);

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
                        g.Estado = "El paquete se encuentra en la central de:" + emp.NombreEmpresa + " en la direccion:" + emp.Direccion + " " + emp.CiudadUbicacion + "y pronto se hara la entrega";
                        lista1.Add(g);
                    }
                    else { lista1.Add(g); }
                }

                clsPaquete modi = new clsPaquete();
                string res = string.Empty;
                res = modi.ModificarPaq(lista1);

                List<clsFactura> listafact = new List<clsFactura>();
                clsFactura f = new clsFactura();

                foreach (clsFactura facturita in f.Leer()) 
                {
                    if (facturita.Id == fac.Id) 
                    {
                        facturita.Id = fac.Id;
                        facturita.CodigoPaquete = fac.CodigoPaquete;
                        facturita.Dnicliente = fac.Dnicliente;
                        facturita.Empresa = fac.Empresa;
                        facturita.Fechaenvio = fac.Fechaenvio;
                        facturita.Fechallegada = dt.Value;
                        facturita.Postal = fac.Postal;
                        facturita.Precio = fac.Precio;
                        facturita.Nombrecliente = fac.Nombrecliente;

                        listafact.Add(facturita);
                    }
                    else { listafact.Add(facturita); }
                }

                clsFactura m= new clsFactura();
                string resFac = string.Empty;
                resFac = m.ModificarFac(listafact);

                if (res == string.Empty && resFac==string.Empty) 
                {
                    MessageBox.Show("ok");
                }
                else { MessageBox.Show("error"); }
            }
            else { MessageBox.Show("seleccione"); }

        }
    }
}
