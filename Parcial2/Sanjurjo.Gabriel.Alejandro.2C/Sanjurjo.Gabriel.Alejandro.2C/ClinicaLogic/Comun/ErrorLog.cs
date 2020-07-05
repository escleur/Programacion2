using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClinicaLogic.Comun
{
    public static class ErrorLog
    {

        /// <summary>
        /// Guarda un mensaje de error en un archivo de log
        /// </summary>
        /// <param name="msg"></param>
        public static void Log(string msg)
        {

            string archivo = Environment.CurrentDirectory + "\\Errors.log";

            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(archivo, true);
                writer.Write(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                writer.WriteLine($" - {msg}");
            }
            catch (Exception ex)
            {

            }
            finally
            {
                writer.Close();
            }

        }
    }
}
