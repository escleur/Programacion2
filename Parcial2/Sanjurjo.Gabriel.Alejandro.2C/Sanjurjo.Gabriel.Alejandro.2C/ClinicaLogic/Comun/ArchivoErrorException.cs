using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClinicaLogic.Comun
{
    class ArchivoErrorException : Exception
    {
        public ArchivoErrorException(string mensaje) : base(mensaje)
        {

        }
        public ArchivoErrorException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }

    }
}
