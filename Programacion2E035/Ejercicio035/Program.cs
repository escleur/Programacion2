using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio035
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo e = new Equipo(5, "River");
            DateTime date1 = new DateTime(2000, 10, 5, 6, 30, 10);
            DirectorTecnico dt = new DirectorTecnico("alberti", date1);
            DateTime date2 = new DateTime(2000, 10, 5, 9, 0, 10);
            DirectorTecnico dt2 = new DirectorTecnico("alberti", date2);
            if(dt == dt2)
            {
                Console.WriteLine("Son iguales");
            }
        }
    }
}
