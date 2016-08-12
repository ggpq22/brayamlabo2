using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using claseArchivo;
using System.Collections;

namespace misClases
{
   public class clsPaquete:clsObjeto
    {
       clsArchivoBinario paquete = new clsArchivoBinario("B://prueba","paquetes.dat");

       int id;
       string nombreDestinatario;
       int dniDestinatario;
       string ciudad;
       string direccion;
       double kilos;
       bool estado;

       public int Id 
       {
           set { id = value; }
           get { return id; }
       }

 
       public string Ciudad 
       {
           set { ciudad = value; }
           get { return ciudad; }
       }

      
       public string Direccion 
       {
           set { direccion = value; }
           get { return direccion; }
       }

       public double Kilos 
       {
           set { kilos = value; }
           get { return kilos; }
       }

       public string NombreDestinatario 
       {
           set { nombreDestinatario = value;}
           get { return nombreDestinatario;}
       }

       public int DniDestinatario 
       {
           set { dniDestinatario = value; }
           get { return dniDestinatario; }
       }

       public bool Estado 
       {
           set { estado = value; }
           get { return estado;}
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
           clsPaquete p = new clsPaquete();
           ArrayList AL = p.Leer();

           if (AL.Count == 0)
           {
               darId = 0;
           }
           else
           {
               p = (clsPaquete)AL[AL.Count - 1];
               darId = p.id;
           }

           return darId;
       }

       public string ModificarPaq(List<clsPaquete> mod)
       {
           string res = string.Empty;
           paquete.Borrar();
           foreach (clsPaquete nuevo in mod)
           {
               res = nuevo.Grabar();
           }

           return res;

       }

       public clsPaquete recuperarPaquete(int i) 
       {
           clsPaquete aux = new clsPaquete();
           clsPaquete retornar = new clsPaquete();
           foreach (clsPaquete buscar in aux.Leer()) 
           {
               if (buscar.Id == i) 
               {
                   retornar = buscar;
               }
           }

           return retornar;
       }
    }
}
