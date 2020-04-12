using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 04";

            //buscar los primeros 4 numeros perfectos

            int cantidad = 0;
            int numeroEvaluado = 1;

            Console.WriteLine("Primeros 4 numeros perfectos");

            do
            {
                int sumaDeDivisores = 0;

                for(int i = 1; i < numeroEvaluado; i++)
                {
                    if(numeroEvaluado % i == 0)
                    {
                        sumaDeDivisores += i;
                    }

                }
                if(sumaDeDivisores == numeroEvaluado)
                {
                    Console.WriteLine(numeroEvaluado);
                    cantidad++;
                }
                numeroEvaluado++;
            } while (cantidad < 4);

            Console.ReadKey();
        }
    }
}
