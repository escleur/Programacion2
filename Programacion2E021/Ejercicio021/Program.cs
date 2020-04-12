using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temperatura;

namespace Ejercicio021
{
    class Program
    {
        static void Main(string[] args)
        {
            Fahrenheit f1 = new Fahrenheit(20);
            Fahrenheit f2 = new Fahrenheit(0);
            Celsius c1 = new Celsius(20);
            Celsius c2 = new Celsius(0);
            Kelvin k1 = new Kelvin(20);
            Kelvin k2 = new Kelvin(0);
            Kelvin k3 = new Kelvin(0);

            f1 = f1 + c1;
            Console.WriteLine(f1.ToString());

            c2 = c2 + k1;
            Console.WriteLine(c2.ToString());

            k2 = k2 + c1;
            Console.WriteLine(k2.ToString());

            c2 = k2;

            if(c2 == k2)
            {
                Console.WriteLine("Son iguales");
            }

            Console.ReadKey();
        }
    }
}
