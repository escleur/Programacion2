using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoBasquet> torneo = new Torneo<EquipoBasquet>("Torneo de basquet");
            Torneo<EquipoFutbol> torneo2 = new Torneo<EquipoFutbol>("Torneo de futbol");
            EquipoBasquet eb1 = new EquipoBasquet("River", new DateTime(1910, 10, 4));
            EquipoBasquet eb2 = new EquipoBasquet("Real Madrid", new DateTime(1940, 1, 10));
            EquipoBasquet eb3 = new EquipoBasquet("Racing", new DateTime(1924, 1, 29));
            EquipoFutbol ef1 = new EquipoFutbol("River", new DateTime(1910, 10, 4));
            EquipoFutbol ef2 = new EquipoFutbol("Real Madrid", new DateTime(1940, 1, 10));
            EquipoFutbol ef3 = new EquipoFutbol("Racing", new DateTime(1924, 1, 29));
            bool agrego = torneo + eb1;
            agrego = torneo + eb2;
            agrego = torneo + eb3;
            agrego = torneo + eb3;
            agrego = torneo2 + ef1;
            agrego = torneo2 + ef2;
            agrego = torneo2 + ef3;

            Console.WriteLine(torneo.Mostrar());
            Console.WriteLine(torneo2.Mostrar());

            Console.WriteLine(torneo.JugarPartido);
            Console.WriteLine(torneo.JugarPartido);
            Console.WriteLine(torneo.JugarPartido);
            Console.ReadKey();






        }
    }
}
