using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio012
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            int n;
            int total = 0;
            char confirmacion;
            do
            {
                do
                {
                    Console.WriteLine("Ingrese un numero");
                    entrada = Console.ReadLine();
                } while (!int.TryParse(entrada, out n));

                total += n;
                Console.WriteLine("Continuar? (S/N)");
                confirmacion = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (ValidarRespuesta.ValidaS_N(confirmacion));
            Console.WriteLine("Suma: {0}", total);
            Console.ReadKey();
        }
    }
}
