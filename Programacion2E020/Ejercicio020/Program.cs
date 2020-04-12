using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio020
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar dolar1 = new Dolar(0);
            Dolar dolar2 = new Dolar(1);
            Euro euro1 = new Euro(0);
            Euro euro2 = new Euro(1);
            Pesos peso1 = new Pesos(0);
            Pesos peso2 = new Pesos(1);


            Console.WriteLine(((Euro)dolar2).ToString());
            Console.WriteLine(((Euro)peso2).ToString());
            Console.WriteLine(((Euro)euro2).ToString());

            Console.WriteLine(((Dolar)dolar2).ToString());
            Console.WriteLine(((Dolar)peso2).ToString());
            Console.WriteLine(((Dolar)euro2).ToString());

            Console.WriteLine(((Pesos)dolar2).ToString());
            Console.WriteLine(((Pesos)peso2).ToString());
            Console.WriteLine(((Pesos)euro2).ToString());

            Console.WriteLine((dolar2 + peso2).ToString());
            Console.WriteLine((dolar2 + euro2).ToString());

            Console.WriteLine((euro2 + peso2).ToString());
            Console.WriteLine((euro2 + dolar2).ToString());

            Console.WriteLine((peso2 + dolar2).ToString());
            Console.WriteLine((peso2 + euro2).ToString());

            Console.WriteLine((dolar2 - peso2).ToString());
            Console.WriteLine((dolar2 - euro2).ToString());

            Console.WriteLine((euro2 - peso2).ToString());
            Console.WriteLine((euro2 - dolar2).ToString());

            Console.WriteLine((peso2 - dolar2).ToString());
            Console.WriteLine((peso2 - euro2).ToString());


            Console.ReadKey();

        }
    }
}
