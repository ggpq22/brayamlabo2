using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using claseArchivo;
using System.Collections;
namespace misClases
{

    
    public class clsUsuario:clsObjeto
    {
        clsArchivoBinario admin = new clsArchivoBinario("C://prueba","administrador.dat");

        string nombre;
        string usuario;
        string contraseña;
        string tipoUsuario;

        public string TipoUsuario
        {
            get { return tipoUsuario; }
            set { tipoUsuario = value; }
        }

        public string Nombre 
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public string Usuario
        {
            set { usuario = value; }
            get { return usuario; }
        }
        public string Contraseña
        {
            set { contraseña = value; }
            get { return contraseña; }
        }

        public string Grabar() 
        {
            return admin.Grabar(this);
        }

        public ArrayList Leer() 
        {
            return admin.Leer(this);
        }
    }
}
