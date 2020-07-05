using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class MiClase
    {
        public static void MetodoEstatico()
        {
            try
            {
                int b = 0;
                int a = 2 / b;
            }
            catch (DivideByZeroException ex)
            {

                throw ex;
            }
        }
        public MiClase()
        {
            try
            {
                MetodoEstatico();
            }
            catch (Exception ex)
            {

                throw new UnaExcepcion("Error al dividir por 2", ex);
            }

        }
        public MiClase(string nombre)
        {
            try
            {
                MetodoEstatico();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
