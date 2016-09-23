using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using claseArchivo;
using System.Collections;
namespace misClases
{
   public class clsDevolucion:clsObjeto
    {
       clsArchivoBinario devolucion = new clsArchivoBinario("C://prueba","devoluciones.dat");

       int id;
       string codigoPaquete;
       DateTime fechaDevolucion;
       string estado;
       string haciaEmpresa;
       string desdeEmpresa;
       string motivoDevolucion;
       public int Id 
       {
           set { id = value; }
           get { return id; }
       }

       public string CodigoPaquete 
       {
           set { codigoPaquete = value; }
           get { return codigoPaquete; }
       }

       public string HaciaEmpresa 
       {
           set { haciaEmpresa = value; }
           get { return haciaEmpresa; }
       }

       public string DesdeEmpresa
       {
           set { DesdeEmpresa = value; }
           get { return DesdeEmpresa; }
       }

       public DateTime FechaDevolucion 
       {
           set { fechaDevolucion = value; }
           get { return fechaDevolucion; }
       }

       public string Estado 
       {
           set { estado = value; }
           get { return estado; }
       }

       public string MotivoDevolucion 
       {
           set { motivoDevolucion = value; }
           get { return motivoDevolucion; }
       }

       public ArrayList Leer() 
       {
           return devolucion.Leer(this);
       }

       public string Grabar() 
       {
           return devolucion.Grabar(this);
       }

       public int RecuperarUltimoId()
       {
           int darId = 0;
           clsDevolucion p = new clsDevolucion();
           ArrayList AL = p.Leer();

           if (AL.Count == 0 || AL == null)
           {
               darId = 0;
           }
           else
           {
               if ((clsDevolucion)AL[AL.Count - 1] != null)
               {
                   p = (clsDevolucion)AL[AL.Count - 1];
                   darId = p.id;
               }
               else
               {
                   darId = 0;
               }
           }

           return darId;
       }

    }
}
