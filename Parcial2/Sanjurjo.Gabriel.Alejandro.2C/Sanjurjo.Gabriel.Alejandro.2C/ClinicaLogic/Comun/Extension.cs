using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaLogic.Comun
{
    public static class Extension
    {
        /// <summary>
        /// Metodo de extension que muestra "apellido, nombre"
        /// </summary>
        /// <param name="apellido"></param>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public static string ApellidoYNombre(this string apellido, string nombre)
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}, {1}", apellido, nombre);
            return sb.ToString();
        }
    }
}
