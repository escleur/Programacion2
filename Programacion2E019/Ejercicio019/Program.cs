using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio019
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador s = new Sumador();
            Console.WriteLine(s.Sumar(10, 20));
            Console.WriteLine(s.Sumar("Hola", "Chau"));
            Console.WriteLine((int)s);

            Sumador s2 = new Sumador();
            Console.WriteLine(s2.Sumar(10, 20));
            Console.WriteLine(s2.Sumar("Hola", "Chau"));
            Console.WriteLine((int)s2);

            Console.WriteLine(s + s2);

            Console.WriteLine(s | s2);

            Console.ReadKey();
        }
    }
}
