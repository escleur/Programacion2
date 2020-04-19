using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;


namespace Ejercicio030
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoF1 a1 = new AutoF1(10, "Roja");
            AutoF1 a2 = new AutoF1(11, "Roja");
            AutoF1 a3 = new AutoF1(10, "Naranja");
            AutoF1 a4 = new AutoF1(10, "Roja");
            AutoF1 a5 = new AutoF1(11, "Naranja");

            Competencia c = new Competencia(5, 10);

            if (c + a1)
            {
                Console.WriteLine("Se agrego a1");
            }
            if (c + a2)
            {
                Console.WriteLine("Se agrego a2");
            }
            if (c + a3)
            {
                Console.WriteLine("Se agrego a3");
            }
            if (c + a4)
            {
                Console.WriteLine("Se agrego a4");
            }
            if (c + a5)
            {
                Console.WriteLine("Se agrego a5");
            }
            Console.WriteLine(c.MostrarDatos());
            Console.ReadKey();
            if (c - a1)
            {
                Console.WriteLine("Se quito a1");
            }
            Console.WriteLine(c.MostrarDatos());
            Console.ReadKey();
        }
    }
}
