using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Reflection;

namespace claseArchivo
{
   public class clsArchivoBinario
    {
        string archivo;
        string directorio;
        string nombreCompleto;

        public clsArchivoBinario(string Directorio, string Archivo)
        {
            if (!Directory.Exists(Directorio))
            {
                Directory.CreateDirectory(Directorio);
            }
            directorio = Directorio;
            archivo = Archivo;
            nombreCompleto = directorio + "\\" + archivo;

        }

        public string Grabar(clsObjeto sender)
        {
            string res = string.Empty;

            FileStream fs;
            BinaryWriter bw;

            Type tipo = null;
            PropertyInfo[] propiedades = null;
            tipo = sender.GetType();
            propiedades = tipo.GetProperties();


            if (!File.Exists(nombreCompleto))
            {
                fs = new FileStream(nombreCompleto, FileMode.Create);
            }
            else
            {
                fs = new FileStream(nombreCompleto, FileMode.Append);
            }

            bw = new BinaryWriter(fs,Encoding.UTF8);

            try
            {

                foreach (PropertyInfo prop in propiedades)
                {
                    object o = prop.GetValue(sender, null);
                    tipo = prop.PropertyType;
                    string nombre = prop.Name;

                    switch (tipo.ToString())
                    {
                        case "System.String":
                            bw.Write(o.ToString());
                            break;
                        case "System.Int32":
                            bw.Write(int.Parse(o.ToString()));
                            break;

                        case "System.DateTime":
                            bw.Write(o.ToString());
                            break;

                        case "System.Decimal":
                            bw.Write(decimal.Parse(o.ToString()));
                            break;

                        case "System.Double":
                            bw.Write(double.Parse(o.ToString()));
                            break;

                        case "System.Boolean":
                            bw.Write(Boolean.Parse(o.ToString()));
                            break;

                        case "System.char":
                            bw.Write(char.Parse(o.ToString()));
                            break;

                    }
                }
            }
            catch (Exception ex)
            {
                res = ex.Message.ToString();

            }

            bw.Close();
            fs.Close();
            fs.Dispose();

            return res;
        }

        public ArrayList Leer(clsObjeto sender)
        {

            ArrayList Lista = new ArrayList();


            FileStream fs = new FileStream(nombreCompleto, FileMode.OpenOrCreate,FileAccess.Read);
            BinaryReader br=new BinaryReader(fs);

            Type tipo = null;
            PropertyInfo[] propiedades = null;
            tipo = sender.GetType();
            propiedades = tipo.GetProperties();

            try
            {
                while (br.PeekChar() != -1)
                {
                    clsObjeto obj = new clsObjeto();


                    foreach (PropertyInfo prop in propiedades)
                    {
                        object o = prop.GetValue(sender, null);
                        tipo = prop.PropertyType;
                        string nombre = prop.Name;

                        switch (tipo.ToString())
                        {
                            case "System.String":
                                prop.SetValue(sender, br.ReadString(), null);
                                break;
                            case "System.Int32":
                                prop.SetValue(sender, br.ReadInt32(), null);
                                break;

                            case "System.DateTime":
                                prop.SetValue(sender, DateTime.Parse(br.ReadString()), null);
                                break;


                            case "System.Decimal":
                                prop.SetValue(sender, br.ReadDecimal(), null);
                                break;

                            case "System.Double":
                                prop.SetValue(sender, br.ReadDouble(), null);
                                break;

                            case "System.Boolean":
                                prop.SetValue(sender, br.ReadBoolean(), null);
                                break;

                            case "System.char":
                                prop.SetValue(sender, br.ReadChar(), null);
                                break;
                        }

                    }

                    obj = sender.Copiar();

                    Lista.Add(obj);
                }

            }
            catch (Exception)
            {
                Lista.Add(null);
            }

            br.Close();
            fs.Close();
            fs.Dispose();

            return Lista;

        }

        public void Borrar()
        {

            FileStream fs = new FileStream(nombreCompleto, FileMode.Create);
            fs.Close();
            fs.Dispose();

        }

    }
}
