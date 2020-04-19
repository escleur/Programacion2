using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        public static Random random;
        public static int Orden(int a, int b)
        {
            int retorno = 0;
            if (a < b) retorno = 1;
            if (a > b) retorno = -1;
            return retorno;
        }
        static void Main(string[] args)
        {
            random = new Random();
            int[] array = new int[20];


            for (int i = 0; i < 20; i++)
            {
                array[i] = (random.Next(-1000, 1000));
            }

            Console.WriteLine("Punto a");
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

            Array.Sort(array, Orden);

            Console.WriteLine("Punto b");
            foreach (int item in array)
            {
                if (item > 0)
                    Console.WriteLine(item);
            }

            Console.ReadKey();

            Array.Sort(array);

            Console.WriteLine("Punto b");
            foreach (int item in array)
            {
                if (item < 0)
                    Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
