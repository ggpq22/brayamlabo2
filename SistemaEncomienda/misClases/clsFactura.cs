using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using misClases;
using claseArchivo;
namespace misClases
{
   public class clsFactura:clsObjeto
    {
       clsArchivoBinario paquete = new clsArchivoBinario("B://prueba", "encomiendas.dat");

       int id;
       string  nombrecliente;
       int dnicliente;
       string codigoPaquete;
       float precio;
       DateTime fechaenvio;
       string empresa;

       public int Id 
       {
           set { id = value; }
           get { return id; }
       }

       public string Nombrecliente 
       {
           set { nombrecliente = value; }
           get { return nombrecliente; }
       }

       public int Dnicliente 
       {
           set { dnicliente = value; }
           get { return dnicliente; }
       }

       public string CodigoPaquete 
       {
           set { codigoPaquete = value; }
           get { return codigoPaquete; }
       }

       public float Precio 
       {
           set { precio = value; }
           get { return precio; }
       }

       public DateTime Fechaenvio 
       {
           set { fechaenvio = value; }
           get { return fechaenvio; }
       }

       public string Empresa 
       {
           set { empresa = value; }
           get { return empresa; }
       }

       public string Grabar() 
       {
           return paquete.Grabar(this);
       }

       public ArrayList Leer() 
       {
           return paquete.Leer(this);
       }

       public int RecuperarUltimoId()
       {
           int darId = 0;
           clsFactura e = new clsFactura();
           ArrayList AL = e.Leer();

           if (AL.Count == 0)
           {
               darId = 0;
           }
           else
           {
               e = (clsFactura)AL[AL.Count - 1];
               darId = e.id;
           }

           return darId;
       }


       public clsFactura recuperarFac(string codPaq) 
       {

           clsFactura retornar = null;
           clsFactura aux = new clsFactura();

           foreach (clsFactura c in aux.Leer())
           {
               if (c.codigoPaquete == codPaq)
               {
                   retornar = c;
               }
           }

           return retornar;
       }
    }
}
