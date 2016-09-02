using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using claseArchivo;
using System.Collections;
namespace misClases
{
   public  class clsEmpresa : clsObjeto
    {
       clsArchivoBinario empresa = new clsArchivoBinario("C://prueba", "empresa.dat");
       
       int id;
       string nombreEmpresa;
       string ciudadUbicacion;
       string direccion;
       string telefono;

       public int Id
       {
           set { id = value; }
           get { return id; }
       }

       public string CiudadUbicacion 
       {
           set { ciudadUbicacion = value; }
           get { return ciudadUbicacion; }
       }

       public string NombreEmpresa 
       {
           set { nombreEmpresa = value; }
           get { return nombreEmpresa; }
       }
       public string Direccion 
       {
           set { direccion = value; }
           get { return direccion; }
       }

       public string Telefono 
       {
           set { telefono = value; }
           get { return telefono; }
       }

       public ArrayList Leer()
       {
           return empresa.Leer(this);
       }

       public string Grabar()
       {
           return empresa.Grabar(this);
       }
       public int RecuperarUltimoId()
       {
           int darId = 0;
           clsEmpresa p = new clsEmpresa();
           ArrayList AL = p.Leer();

           if (AL.Count == 0 || AL == null)
           {
               darId = 0;
           }
           else
           {
               if ((clsEmpresa)AL[AL.Count - 1] != null)
               {
                   p = (clsEmpresa)AL[AL.Count - 1];
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
