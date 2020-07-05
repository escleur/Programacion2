using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio042
{
    class Program
    {
        static void Main(string[] args)
        {
            OtraClase oc = new OtraClase();
            try
            {
                oc.metodo();

            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.StackTrace);
                do
                {
                    Console.WriteLine(ex.Message);
                    ex = ex.InnerException;
                } while (ex != null);

            }
            Console.ReadKey();
        }
    }
}
