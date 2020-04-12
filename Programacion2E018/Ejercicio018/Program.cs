using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rec = new Rectangulo(new Punto(5,5), new Punto(10,10));
            Console.WriteLine("El area es {0}", rec.Area());
            Console.WriteLine("El perimetro es {0}", rec.Perimetro());
           
            Console.WriteLine(rec.ToString());
            Console.ReadKey();
        }
    }
}
