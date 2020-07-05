using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio036
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia<AutoF1> c = new Competencia<AutoF1>(5, 10, Competencia<AutoF1>.TipoCompetencia.F1);
            AutoF1 a1 = new AutoF1(4, "Rabioles");
            AutoF1 a2 = new AutoF1(6, "Rabioles");
            MotoCross m1 = new MotoCross(1, "Nioquis");

            bool entro;
            try
            {
                entro = c + a1;

            }
            catch (CompetenciaNoDisponibleException e)
            {
                Console.WriteLine(e.ToString());
            }
            try
            {
                entro = c + a2;

            }
            catch (CompetenciaNoDisponibleException e)
            {
                Console.WriteLine(e.ToString());
            }
            try
            {
                entro = c + a2;

            }
            catch (CompetenciaNoDisponibleException e)
            {
                Console.WriteLine(e.ToString());
            }
            try
            {
                entro = c + m1;

            }
            catch (CompetenciaNoDisponibleException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }
    }
}
