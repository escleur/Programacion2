using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio008
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 08";

            string entrada;

            int valorHora;
            string nombre;
            int antiguedad;
            int horasTrabajadas;

            int n;

            do
            {
                Console.WriteLine("Ingrese cantidad de empleados");
                entrada = Console.ReadLine();
            } while (!int.TryParse(entrada, out n) && n >= 0);
            for(int i = 0; i < n; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese el valor de la hora");
                    entrada = Console.ReadLine();
                } while (!int.TryParse(entrada, out valorHora) && valorHora >= 0);
                Console.WriteLine("Ingrese el nombre");
                nombre = Console.ReadLine();
                do
                {
                    Console.WriteLine("Ingrese antiguedad");
                    entrada = Console.ReadLine();
                } while (!int.TryParse(entrada, out antiguedad) && antiguedad >= 0);
                do
                {
                    Console.WriteLine("Ingrese horas trabajadas en el mes");
                    entrada = Console.ReadLine();
                } while (!int.TryParse(entrada, out horasTrabajadas) && horasTrabajadas >= 0);

                int ingresoBruto = valorHora * horasTrabajadas + antiguedad * 150;
                int descuento = ingresoBruto * 13 / 100;
                int neto = ingresoBruto - descuento;

                Console.WriteLine($"Recibo Nombre: {nombre}  Ant: {antiguedad}  Valor hora: {valorHora}");
                Console.WriteLine($"Total a cobrar en bruto: {ingresoBruto}  Descuento: {descuento}  Neto: {neto}");

                Console.ReadKey();
            }

        }
    }
}
