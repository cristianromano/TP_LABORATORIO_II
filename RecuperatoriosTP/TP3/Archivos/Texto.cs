using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;


namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        public bool Guardar(string archivo, string datos)
        {
            try
            {

                if (!String.IsNullOrEmpty(archivo) && !String.IsNullOrEmpty(datos))
                {
                    using (StreamWriter sw = new StreamWriter(archivo, false))
                    {
                        sw.WriteLine(datos);
                    }

                    return true;
                }
            }
            catch (Exception)
            {

                throw new ArchivosException("Error al intentar guardar archivo de texto");
            }

            return false;
        }
        public bool Leer(string archivo, out string datos)
        {
            try
            {
                datos = String.Empty;

                if (File.Exists(archivo))
                {
                    using (StreamReader sr = new StreamReader(archivo))
                    {
                        datos = sr.ReadToEnd();
                        return true;
                    }
                }
            }
            catch (Exception)
            {

                throw new ArchivosException("Error al intentar leer archivo de texto");
            }

            return false;
        }
    }
}
