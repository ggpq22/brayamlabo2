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
   public class clsEncomienda:clsObjeto
    {
       clsArchivoBinario paquete = new clsArchivoBinario("B://prueba", "encomiendas.dat");

       int id;
       string  nombrecliente;
       int dnicliente;
       int idpaquete;
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

       public int Idpaquete 
       {
           set { idpaquete = value; }
           get { return idpaquete; }
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
           clsEncomienda e = new clsEncomienda();
           ArrayList AL = e.Leer();

           if (AL.Count == 0)
           {
               darId = 0;
           }
           else
           {
               e = (clsEncomienda)AL[AL.Count - 1];
               darId = e.id;
           }

           return darId;
       }
    }
}
