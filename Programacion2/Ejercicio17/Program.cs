using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafoRojo = new Boligrafo(50, ConsoleColor.Red);

            string dibujo;

            for (int i = 0; i < 10; i++)
            {
                if (boligrafoRojo.Pintar(30, out dibujo))
                {
                    Console.WriteLine("Tiene tinta");
                }
                else
                {
                    Console.WriteLine("Sin tinta");
                    boligrafoRojo.Recargar();
                    Console.WriteLine("Recargado");
                }
                Console.ForegroundColor = boligrafoRojo.GetColor();
                Console.WriteLine("Dibujo: {0}", dibujo);

                if (boligrafoAzul.Pintar(10, out dibujo))
                {
                    Console.WriteLine("Tiene tinta");
                }
                else
                {
                    Console.WriteLine("Sin tinta");
                    boligrafoRojo.Recargar();
                    Console.WriteLine("Recargado");
                }
                Console.ForegroundColor = boligrafoAzul.GetColor();
                Console.WriteLine("Dibujo: {0}", dibujo);
            }
            Console.ReadKey();
        }
    }
}
