using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio016
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();

            alumno1.nombre = "Maria";
            alumno1.apellido = "Neglia";
            alumno1.legajo = 100002;
            alumno1.Estudiar(4, 7);
            alumno1.CalcularFinal();

            alumno2.nombre = "Alex";
            alumno2.apellido = "Neguer";
            alumno2.legajo = 100000;
            alumno2.Estudiar(2, 4);
            alumno2.CalcularFinal();

            alumno3.nombre = "Pepe";
            alumno3.apellido = "Salto";
            alumno3.legajo = 100001;
            alumno3.Estudiar(9, 9);
            alumno3.CalcularFinal();


            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());

            Console.ReadLine();
        }
    }
}
