using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClinicaLogic.Comun
{
    public class ClinicaNoCoincideException : Exception
    {
        public ClinicaNoCoincideException(string mensaje) : base(mensaje)
        {

        }
        public ClinicaNoCoincideException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }

    }
}
