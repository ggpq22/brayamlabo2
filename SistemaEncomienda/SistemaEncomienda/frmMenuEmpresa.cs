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
        List<clsFactura> lista;
        clsFactura aux = new clsFactura();
        public frmMenuEmpresa(string nombre)
        {
            this.nombre = nombre;
            InitializeComponent();
        }



        private void frmMenuEmpresa_Load(object sender, EventArgs e)
        {
            clsFactura b = new clsFactura();
            dgvEnviosRecibidos.DataSource = null;
            lista = new List<clsFactura>();
            lista = b.traerFacturas(nombre);
            if (lista != null)
            {
                dgvEnviosRecibidos.DataSource = lista;
            }

            dt.Visible = false;
            List<clsSucursal> listasucursal = new List<clsSucursal>();
            clsSucursal a = new clsSucursal();

            foreach (clsSucursal s in a.Leer())
            {
                listasucursal.Add(s);
            }

            dgvSucursal.DataSource = listasucursal;

            dtpFiltroFechaEnvioDesde.Enabled = ckbFiltroFechaEnvioDesde.Checked;
            dtpFiltroFechaEnvioHasta.Enabled = ckbFiltroFechaEnvioHasta.Checked;
        }

        private void btnRecibido_Click(object sender, EventArgs e)
        {
            clsEmpresa emp = new clsEmpresa();
            clsEmpresa aux = new clsEmpresa();
             emp = aux.traerEmpresa(nombre);
            if (dgvEnviosRecibidos.SelectedRows.Count != 0)
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
                if (cambiar.Estado == "Despachado")
                {
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
                            g.Estado = "El paquete se encuentra en la central de:" + emp.NombreEmpresa + " en " + emp.CiudadUbicacion + "ubicada en: " + emp.Direccion + " y pronto se hara la entrega";
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

                    clsFactura m = new clsFactura();
                    string resFac = string.Empty;
                    resFac = m.ModificarFac(listafact);

                    if (res == string.Empty && resFac == string.Empty)
                    {
                        MessageBox.Show("ok");
                    }
                    else { MessageBox.Show("error"); }
                }
                else { MessageBox.Show("Este paquete ya fue recibido"); }
            }
            else { MessageBox.Show("seleccione el paquete"); }

        }

        private void btnTransferir_Click(object sender, EventArgs e)
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
            if (dgvSucursal.SelectedRows.Count != 0)
            {
                if (fac.Postal == int.Parse(dgvSucursal.CurrentRow.Cells["codigoPostal"].Value.ToString()))
                {

                    List<clsFactura> listafact = new List<clsFactura>();
                    clsFactura f = new clsFactura();

                    foreach (clsFactura facturita in f.Leer())
                    {
                        if (facturita.Id == fac.Id)
                        {
                            facturita.Id = fac.Id;
                            facturita.CodigoPaquete = fac.CodigoPaquete;
                            facturita.Dnicliente = fac.Dnicliente;
                            facturita.Empresa = dgvSucursal.CurrentRow.Cells["nombre"].Value.ToString();
                            facturita.Fechaenvio = fac.Fechaenvio;
                            facturita.Fechallegada = dt.Value;
                            facturita.Postal = fac.Postal;
                            facturita.Precio = fac.Precio;
                            facturita.Nombrecliente = fac.Nombrecliente;

                            listafact.Add(facturita);
                        }
                        else { listafact.Add(facturita); }
                    }
                    List<clsPaquete> lista1 = new List<clsPaquete>();
                    clsPaquete cambiar = new clsPaquete();
                    cambiar = cambiar.retornarPaquete(fac.CodigoPaquete);

                    clsPaquete p2 = new clsPaquete();
                    if (cambiar.Estado == "Despachado")
                    {
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
                                g.Estado = "El paquete fue tranferido a la sucursal:" + dgvSucursal.CurrentRow.Cells["nombre"].Value.ToString();
                                lista1.Add(g);
                            }
                            else { lista1.Add(g); }
                        }
                    }
                    clsPaquete modi = new clsPaquete();
                    string res = string.Empty;
                    res = modi.ModificarPaq(lista1);
                    clsFactura m = new clsFactura();
                    string resFac = string.Empty;
                    resFac = m.ModificarFac(listafact);



                    if (resFac == string.Empty && res == string.Empty)
                    {
                        MessageBox.Show("El paquete fue transferido");
                    }

                    else { MessageBox.Show("error"); }
                }
                else { MessageBox.Show("No coinciden el codigo postal de la sucursal con el del paquete por favor verifique bien"); }
            }
            else { MessageBox.Show("Seleccione una sucursal"); }
        }
        private void btnDevolver_Click(object sender, EventArgs e)
        {

            clsFactura fac = new clsFactura();
            if (dgvEnviosRecibidos.SelectedRows.Count != 0)
            {
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
                if (cambiar.Estado == "Despachado")
                {
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
                            g.Estado = "El paquete fue devuelto al local donde usted envio la encomienda,para mas informacion comuniquese al 0800456788";
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

                    clsFactura m = new clsFactura();
                    string resFac = string.Empty;
                    resFac = m.ModificarFac(listafact);
                    if (res == string.Empty && resFac == string.Empty)
                    {
                        MessageBox.Show("los datos fueron actualizados");
                    }

                    else { MessageBox.Show("ocurrio el siguiente error:" + res + resFac); }

                }
                else { MessageBox.Show("No puede realizar esta operacion"); }
            }
            else { MessageBox.Show("Seleccione la encomienda"); }
        }

        private void tbFiltroCodigoPaquete_TextChanged(object sender, EventArgs e)
        {
            filtros();
        }

        public void filtros()
        {
            lista = new List<clsFactura>();
            foreach (clsFactura f in aux.Leer())
            {
                lista.Add(f);
            }
            dgvEnviosRecibidos.DataSource = lista;

  
            if (tbFiltroCodigoPaquete.Text != string.Empty)
            {
                for (int i = 0; i < dgvEnviosRecibidos.Rows.Count; i++)
                {
                    if (tbFiltroCodigoPaquete.Text.Length > Convert.ToString(dgvEnviosRecibidos.Rows[i].Cells["CodigoPaquete"].Value).Length || Convert.ToString(dgvEnviosRecibidos.Rows[i].Cells["CodigoPaquete"].Value).Substring(0, tbFiltroCodigoPaquete.Text.Length).ToLower().CompareTo(tbFiltroCodigoPaquete.Text.ToLower()) != 0)
                    {
                        dgvEnviosRecibidos.CurrentCell = null;
                        dgvEnviosRecibidos.Rows[i].Visible = false;

                    }
                }
            }

            dtpFiltroFechaEnvioDesde.Enabled = ckbFiltroFechaEnvioDesde.Checked;
            dtpFiltroFechaEnvioHasta.Enabled = ckbFiltroFechaEnvioHasta.Checked;

            if ((ckbFiltroFechaEnvioDesde.Checked) && (ckbFiltroFechaEnvioHasta.Checked))
            {

                for (int i = 0; i < dgvEnviosRecibidos.Rows.Count; i++)
                {
                    if ((Convert.ToDateTime(dgvEnviosRecibidos.Rows[i].Cells["Fechaenvio"].Value).Date < Convert.ToDateTime(dtpFiltroFechaEnvioDesde.Value).Date) || (Convert.ToDateTime(dgvEnviosRecibidos.Rows[i].Cells["Fechaenvio"].Value).Date > Convert.ToDateTime(dtpFiltroFechaEnvioHasta.Value).Date))
                    {
                        dgvEnviosRecibidos.CurrentCell = null;
                        dgvEnviosRecibidos.Rows[i].Visible = false;

                    }
                }

            }
            else if ((ckbFiltroFechaEnvioDesde.Checked) && (!ckbFiltroFechaEnvioHasta.Checked))
            {
                for (int i = 0; i < dgvEnviosRecibidos.Rows.Count; i++)
                {
                    if ((Convert.ToDateTime(dgvEnviosRecibidos.Rows[i].Cells["Fechaenvio"].Value).Date < Convert.ToDateTime(dtpFiltroFechaEnvioDesde.Value).Date))
                    {
                        dgvEnviosRecibidos.CurrentCell = null;
                        dgvEnviosRecibidos.Rows[i].Visible = false;

                    }
                }
            }
            else if ((!ckbFiltroFechaEnvioDesde.Checked) && (ckbFiltroFechaEnvioHasta.Checked))
            {
                for (int i = 0; i < dgvEnviosRecibidos.Rows.Count; i++)
                {
                    if ((Convert.ToDateTime(dgvEnviosRecibidos.Rows[i].Cells["Fechaenvio"].Value).Date > Convert.ToDateTime(dtpFiltroFechaEnvioHasta.Value).Date))
                    {
                        dgvEnviosRecibidos.CurrentCell = null;
                        dgvEnviosRecibidos.Rows[i].Visible = false;

                    }
                }
            }

            int indice = 0;
            bool continuar = false;
            while (indice < dgvEnviosRecibidos.Rows.Count && !continuar)
            {
                if (dgvEnviosRecibidos.Rows[indice].Visible)
                {
                    dgvEnviosRecibidos.Rows[indice].Selected = true;
                    continuar = true;
                }
                indice++;
            }


        }

    }
}

