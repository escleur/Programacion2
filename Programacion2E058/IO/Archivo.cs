using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    [Serializable]
    public abstract class Archivo
    {
        protected virtual bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            bool retorno = true;
            if (validaExistencia)
            {
                if (!File.Exists(ruta))
                {
                    throw new FileNotFoundException("No se encontro el archivo.");
                }
            
            }
            return retorno;
        }
    }
}
