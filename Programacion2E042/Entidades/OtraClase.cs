using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OtraClase
    {
        public void metodo()
        {
            try
            {
                MiClase mc = new MiClase();

            }
            catch (UnaExcepcion ex)
            {

                throw new MiExcepcion("una excepcion cazada", ex);
            }
        }
    }
}
