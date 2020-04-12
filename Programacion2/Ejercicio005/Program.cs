using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 5";

            string respuesta;
            int numeroIngresado;
            int numeroEvaluado;
            int i;
            int parteMenor;
            int parteMayor;
            Console.WriteLine("Ingrese un numero.");

            respuesta = Console.ReadLine();
            while (!int.TryParse(respuesta, out numeroIngresado))
            {
                if (respuesta.ToLower() == "salir")
                {
                    Environment.Exit(0);
                }
                respuesta = Console.ReadLine();

            }



            Console.WriteLine("Los numeros centro son:");

            for (numeroEvaluado = 2; numeroEvaluado <= numeroIngresado; numeroEvaluado++)
            {
                parteMenor = 0;
                for (i = 1; i < numeroEvaluado; i++)
                {
                    parteMenor += i;
                }
                parteMayor = parteMenor;
                i = numeroEvaluado;
                while (parteMayor > 0)
                {
                    i++;
                    parteMayor -= i;
                }
                if (parteMayor == 0)
                {
                    Console.WriteLine(numeroEvaluado);
                }

            }
            Console.ReadKey();
            

        }
    }
}
