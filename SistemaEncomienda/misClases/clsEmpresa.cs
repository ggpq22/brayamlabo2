using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace misClases
{
   public  class clsEmpresa
    {
       int idEmpresa;
       string nombreEmpresa;
       string ciudadUbicacion;
       string direccion;

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
