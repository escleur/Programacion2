using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";

            string mensaje;
            int numero;
            int i = 0;
            int maximo=0;
            int minimo=0;
            double promedio = 0;
            do
            {

                Console.WriteLine("Ingrese un numero ");
                mensaje = Console.ReadLine();

                if (int.TryParse(mensaje, out numero))
                {
                    i++;
                    promedio += numero;
                    if (i == 1)
                    {
                        maximo = numero;
                        minimo = numero;
                    }
                    if (maximo < numero)
                    {
                        maximo = numero;
                    }
                    if(minimo > numero)
                    {
                        minimo = numero;
                    }
                }

            } while (i < 5);
            promedio /= 5;
            Console.WriteLine("El maximo es {0}", maximo);
            Console.WriteLine("El minimo es {0}", minimo);
            Console.WriteLine("El promedio es {0}", promedio);
            Console.ReadKey();
        }
    }
}
