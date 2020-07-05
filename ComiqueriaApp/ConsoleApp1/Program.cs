using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComiqueriaLogic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Comic comic = new Comic("El hombre arana", 4, 5.8, "Marvel", Comic.TipoComic.Occidental);

            Console.WriteLine(comic.ToString());
            Console.ReadKey();
        }
    }
}
