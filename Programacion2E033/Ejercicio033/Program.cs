using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
namespace Ejercicio033
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro l = new Libro();
            l[0] = "El tiempo y tu humor";
            l[1] = "El tiempo y tu humor 2";
            l[2] = "El tiempo y tu humor 3";
            l[3] = "El tiempo y tu humor 4";
            l[7] = "El tiempo y tu humor 5";
            
            for(int i = 0; i < 7; i++)
            {
                Console.WriteLine(l[i]);
            }
            Console.ReadKey();

        }
    }
}
