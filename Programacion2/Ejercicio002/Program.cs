using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 02";
            string mensaje;
            int numero;
            bool salir = false;
            Console.WriteLine("Ingrese un numero");

            do
            {
                mensaje = Console.ReadLine();

                if (int.TryParse(mensaje, out numero))
                {
                    if (numero > 0)
                    {
                        salir = true;
                    }
                }
                if (!salir)
                {
                    Console.WriteLine("ERROR. Reingresar numero!");
                }
            } while (!salir);
            Console.WriteLine("El cuadrado del numero ingresado es {0} y su cubo es {1}", Math.Pow(numero, 2), Math.Pow(numero, 3));
            Console.ReadKey();
        }
    }
}
