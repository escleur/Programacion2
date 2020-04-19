using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio027
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
            List<int> list = new List<int>();


            for(int i=0; i < 20; i++)
            {
                list.Add(random.Next(-1000,1000));
            }

            Console.WriteLine("Punto a");
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

            list.Sort(Orden);

            Console.WriteLine("Punto b");
            foreach (int item in list)
            {
                if(item > 0)
                    Console.WriteLine(item);
            }

            Console.ReadKey();

            list.Sort();

            Console.WriteLine("Punto b");
            foreach (int item in list)
            {
                if (item < 0)
                    Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
