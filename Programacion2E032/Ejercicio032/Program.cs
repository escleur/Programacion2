using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio029
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo river = new Equipo(30, "River Plate");
            Jugador j1 = new Jugador(199394, "Gallardo", 38, 10);
            Jugador j2 = new Jugador(245676, "Lopez", 38, 10);

            if(river + j1)
            {
                Console.WriteLine("Ingresado {0}", j1.MostrarDatos());
            }
            if (river + j2)
            {
                Console.WriteLine("Ingresado {0}", j2.MostrarDatos());
            }
            Console.ReadKey();
        }
    }
}
