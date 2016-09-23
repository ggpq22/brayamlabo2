using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using claseArchivo;
using System.Collections;
namespace misClases
{
    public class clsSucursal:clsObjeto
    {
        clsArchivoBinario sucu = new clsArchivoBinario("C://prueba", "sucursal.dat");
       
        
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

        string nombre;
        public string Nombre 
        {
            set { nombre = value; }
            get { return nombre; }
        }


        public int RecuperarUltimoId()
        {
            int darId = 0;
            clsSucursal p = new clsSucursal();
            ArrayList AL = p.Leer();

            if (AL.Count == 0 || AL == null)
            {
                darId = 0;
            }
            else
            {
                if ((clsSucursal)AL[AL.Count - 1] != null)
                {
                    p = (clsSucursal)AL[AL.Count - 1];
                    darId = p.idSucursal;
                }
                else
                {
                    darId = 0;
                }
            }

            return darId;
        }

        int idCentral;

        public int IdCentral 
        {
            set { idCentral = value; }
            get { return idCentral; }
        }
        public string Grabar()
        {
            return sucu.Grabar(this);
        }

        public ArrayList Leer()
        {
            return sucu.Leer(this);

        }

        public clsSucursal traerSucursal(string nombre) 
        {
            clsSucursal retornar = new clsSucursal();
            clsSucursal aux = new clsSucursal();
            foreach (clsSucursal a in aux.Leer()) 
            {
                if (a.Nombre == nombre) 
                {
                    retornar = a;
                    break;
                }
            }

            return retornar;
        }

    }
}
