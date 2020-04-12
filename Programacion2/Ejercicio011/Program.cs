using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio011
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 11";

            string mensaje;
            int numero;
            int cantidad = 0;
            int minimo = 0;
            int maximo = 0;
            double promedio = 0;

            do
            {
                Console.WriteLine("Ingrese un numero -100 .. 100");
                if (int.TryParse(Console.ReadLine(), out numero) && Validacion.Validar(numero, -100, 100))
                {
                    cantidad++;
                    if (cantidad == 1)
                    {
                        minimo = numero;
                        maximo = numero;
                    }
                    if (minimo > numero)
                    {
                        minimo = numero;
                    }
                    if (maximo < numero)
                    {
                        maximo = numero;
                    }
                    promedio += numero;

                }
                else
                {
                    Console.WriteLine("Error al ingresar el numero -100 .. 100");
                }
            } while (cantidad < 10);
            promedio /= cantidad;
            Console.WriteLine($"Minimo: {minimo}  Maximo: {maximo}   Promedio: {promedio}");
            Console.ReadKey();
        }
    }

    public class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool validacion = valor >= min && valor <= max;
            return validacion;
        }

    }
}
