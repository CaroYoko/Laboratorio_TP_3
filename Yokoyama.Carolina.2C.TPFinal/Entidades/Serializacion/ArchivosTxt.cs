using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ArchivosTxt
    {
        static string path;

        static ArchivosTxt()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\Archivos-Serializacion\";
        }

        public static void Escribir(string datos)
        {
            string nombreArchivo = path + "Archivos_" + DateTime.Now.ToString("HH_mm_ss") + ".txt";
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                using (StreamWriter sw = new StreamWriter(nombreArchivo))
                {                   
                    sw.WriteLine(datos);
                    sw.WriteLine("\n-----------------------------");
                    sw.WriteLine("\nlA FECHA ES: ");
                    sw.WriteLine(DateTime.Now.ToString());
                }

            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }
        }      



    }
}
