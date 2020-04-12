using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroBinario nb = new NumeroBinario();
            nb = "1001001001";
            Console.WriteLine((string)nb);
            NumeroDecimal nd = new NumeroDecimal();
            Console.WriteLine((double)(nd+nb));

            Console.ReadKey();
        }
    }
}
