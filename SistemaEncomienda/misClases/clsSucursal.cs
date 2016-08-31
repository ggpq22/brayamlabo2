using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using claseArchivo;
namespace misClases
{
    public class clsSucursal:clsObjeto
    {
        int idSucursal;

        public int IdSucursal
        {
            get { return idSucursal; }
            set { idSucursal = value; }
        }
        string localidadUbicacion;

        public string LocalidadUbicacion
        {
            get { return localidadUbicacion; }
            set { localidadUbicacion = value; }
        }
        string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        string provincia;

        public string Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }
        int codigoPostal;

        public int CodigoPostal
        {
            get { return codigoPostal; }
            set { codigoPostal = value; }
        }

    }
}
