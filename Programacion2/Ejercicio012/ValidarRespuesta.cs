using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio012
{
    class ValidarRespuesta
    {
        public static bool ValidaS_N(char c)
        {
            bool valido = false;
            if(c == 's' || c == 'S')
            {
                valido = true;
            }
            return valido;
        }
    }
}
