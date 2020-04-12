using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 03";

            string respuesta;


            do
            {
                int numero;
                string mensaje;

                Console.WriteLine("Ingrese un numero");
                mensaje = Console.ReadLine();

                while (!int.TryParse(mensaje, out numero))
                {
                    Console.WriteLine("Error. Ingrese un numero");
                    mensaje = Console.ReadLine();
                    if (mensaje.ToLower() == "salir")
                    {
                        Environment.Exit(0);
                    }
                }
                Console.WriteLine($"Primos hasta {numero}");

                bool esPrimo;

                for (int numeroEvaluado = 2; numeroEvaluado <= numero; numeroEvaluado++)
                {
                    esPrimo = true;
                    for (int i = 2; i < numeroEvaluado; i++)
                    {
                        if(numeroEvaluado % i == 0)
                        {
                            esPrimo = false;
                        }
                    }
                    if(esPrimo)
                    {
                        Console.WriteLine(numeroEvaluado);
                    }
                }


                Console.WriteLine("Escriba 'si' si desea ingresar otro numero");
                respuesta = Console.ReadLine();


            } while (respuesta.ToLower() == "si");

        }
    }
}
