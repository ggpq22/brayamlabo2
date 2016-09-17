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
       clsArchivoBinario paquete = new clsArchivoBinario("C://prueba", "encomiendas.dat");

       int id;
       string  nombrecliente;
       int dnicliente;
       string codigoPaquete;
       float precio;
       DateTime fechaenvio;
       DateTime fechallegada;
       string empresa;
       int postal;

       public DateTime Fechallegada 
       {
           set { fechallegada = value; }
           get { return fechallegada; }
       }
       public int Postal 
       {
           set { postal = value; }
           get { return postal; }
       }

     
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

       public List<clsFactura> recuperarFac(int dni)
       {

          
          clsFactura aux = new clsFactura();
          List<clsFactura> lista = new List<clsFactura>();
           foreach (clsFactura c in aux.Leer())
           {
               if (c.dnicliente == dni)
               {
                   lista.Add(c);
               }
           }

           return lista;
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


       public string ModificarFac(List<clsFactura> mod)
       {
           string res = string.Empty;
           paquete.Borrar();
           foreach (clsFactura nuevo in mod)
           {
               res = nuevo.Grabar();
           }

           return res;

       }

       public List<clsFactura> traerFacturas(string nomEmpresa)
       {

           List<clsFactura> lista = new List<clsFactura>();
           clsFactura aux = new clsFactura();

           foreach (clsFactura c in aux.Leer())
           {
               if (c.empresa == nomEmpresa)
               {
                   lista.Add(c);
               }
           }

           return lista;
       }


    }
}
