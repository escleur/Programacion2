using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio010
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 10";
            int n;
            string entrada;

            do
            {
                Console.WriteLine("Ingrese la altura");
                entrada = Console.ReadLine();
            } while (!int.TryParse(entrada, out n) && n >= 0);
            string cadena = "*";
            for (int i = 0; i < n; i++)
            {
                for (int j = n - i; j > 0; j--)
                    Console.Write(" ");
                Console.WriteLine("{0}", cadena);
                cadena += "**";
            }
            Console.ReadKey();
        }
    }
}
