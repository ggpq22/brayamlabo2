using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using claseArchivo;
namespace misClases
{
   public  class clsEmpresa : clsObjeto
    {
       int idEmpresa;
       string nombreEmpresa;
       string ciudadUbicacion;
       string direccion;
       string telefono;

       public int IdEmpresa 
       {
           set { idEmpresa = value; }
           get { return idEmpresa; }
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
    }
}
