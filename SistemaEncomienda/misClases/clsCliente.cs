using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using claseArchivo;
using System.Collections;

namespace misClases
{
   public class clsCliente:clsObjeto
    {
        clsArchivoBinario cliente = new clsArchivoBinario("C://prueba","clientes.dat");

        string nombre;
        string apellido;
        int dni;
        string direccion;
        int telefono;
        string email;
        bool estado;

        public string Nombre 
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public string Apellido 
        {
            set { apellido = value; }
            get { return apellido; }
        }

        public int Dni 
        {
            set { dni = value; }
            get { return dni; }
        }

        public string Direccion 
        {
            set { direccion = value; }
            get { return direccion; }
        }

        public int Telefono 
        {
            set { telefono = value; }
            get { return telefono; }
        }

        public string Email 
        {
            set { email = value; }
            get { return email; }
        }

        public bool Estado 
        {
            set { estado = value; }
            get { return estado; }
        }


        public string Grabar() 
        {
            return cliente.Grabar(this);
        }

        public ArrayList Leer() 
        {
            return cliente.Leer(this);
        }

        public string Modificar(List<clsCliente> mod) 
        {
            string res = string.Empty;
            cliente.Borrar();
            foreach (clsCliente nuevo in mod) 
            {
                res=nuevo.Grabar();
            }
           
                return res;
            
        }

        public clsCliente buscarCliente(int d) 
        {
            clsCliente retornar = null;
            clsCliente aux = new clsCliente();

            foreach (clsCliente c in aux.Leer()) 
            {
                if (c.Dni == d) 
                {
                    retornar = c;
                }
            }

            return retornar;
        }

    }
}
