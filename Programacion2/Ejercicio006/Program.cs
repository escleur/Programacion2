using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio006
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 06";

            string message;
            int beginYear;
            int endYear;
            int year;

            do
            {
                Console.WriteLine("Ingrese año de inicio");
                message = Console.ReadLine();
            } while (!int.TryParse(message, out beginYear) && beginYear > 0);

            do
            {
                Console.WriteLine("Ingrese año de finalizacion");
                message = Console.ReadLine();
            } while (!int.TryParse(message, out endYear) && endYear > 0 && beginYear < endYear);

            Console.WriteLine($"Años bisiestos entre {beginYear} - {endYear}");

            for (year = beginYear; year <= endYear; year++)
            {
                if(year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)){
                    Console.WriteLine(year);
                }
            }
            Console.ReadKey();
        }
    }
}
