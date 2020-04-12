using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio014
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 14";
            Console.WriteLine(CalculoDeArea.CalcularCuadrado(19));
            Console.WriteLine(CalculoDeArea.CalcularTriangulo(19,20));
            Console.WriteLine(CalculoDeArea.CalcularCirculo(19));
            Console.ReadKey();
        }
    }

    class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            return Math.Pow(lado, 2);
        }
        public static double CalcularTriangulo(double lado, double altura)
        {
            return lado * altura / 2;
        }
        public static double CalcularCirculo(double radio)
        {
            return Math.PI * radio * radio;
        }

    }
}
