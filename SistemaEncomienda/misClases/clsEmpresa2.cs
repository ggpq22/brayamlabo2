using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using misClases;
using claseArchivo;
using System.Collections;
namespace misClases
{
   public  class clsEmpresa2 : clsObjeto
    {
       clsArchivoBinario empresa2 = new clsArchivoBinario("C://prueba", "empresa2.dat");
       
       int id;
       string nombreEmpresa;
       string ciudadUbicacion;
       string direccion;
       string telefono;
       int codPostal;


       public int CodPostal 
       {
           set { codPostal = value; }
           get { return codPostal; }
       }
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
           return empresa2.Leer(this);
       }

       public string Grabar()
       {
           return empresa2.Grabar(this);
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
                   darId = p.Id;
               }
               else
               {
                   darId = 0;
               }
           }

           return darId;
       }

       public clsEmpresa traerEmpresa(string nombre) 
       {
           clsEmpresa nueva = new clsEmpresa();
           clsEmpresa aux = new clsEmpresa();

           foreach (clsEmpresa a in aux.Leer()) 
           {
               if (a.NombreEmpresa == nombre) 
               {
                   nueva = a;
                   break;
               }
           }

           return nueva;
       }

       public bool existeCodigoPostal(string nombre, int codigo) 
       {
           bool res1 = false;
          

           clsSucursal aux = new clsSucursal();
           clsEmpresa nueva = new clsEmpresa();
           clsEmpresa buscar = new clsEmpresa();
           List<clsSucursal> lista = new List<clsSucursal>();
           buscar = nueva.traerEmpresa(nombre);

           if (buscar.CodPostal == codigo) 
           {
               res1 = true;
           }

           else 
           {
               foreach (clsSucursal c in aux.Leer()) 
               {
                   if (c.IdCentral == buscar.Id) 
                   {
                       lista.Add(c);
                   }
               }


               foreach (clsSucursal retornar in lista) 
               {
                   if (retornar.CodigoPostal == codigo) 
                   {
                       res1 = true;
                   }
               }
          
           }


           return res1;
       }

    }

   }
