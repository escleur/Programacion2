using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio031
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente(1, "Diego");
            Cliente c2 = new Cliente(2, "Suzana");
            Cliente c3 = new Cliente(3, "Pedro");
            Cliente c4 = new Cliente(4, "Gustavo");
            Cliente c5 = new Cliente(5, "Alejandro");
            Cliente c6 = new Cliente(6, "Liliana");
            Cliente c7 = new Cliente(7, "Maria");
            Cliente c8 = new Cliente(8, "Celma");
            Cliente c9 = new Cliente(10, "Dionisio");
            Cliente c10 = new Cliente(7, "Putin");
            Cliente c11 = new Cliente(11, "Carola");

            Negocio n1 = new Negocio("La Martina");
            if (n1 + c1)
            {
                Console.WriteLine("Cliente agregado");
            }
            if (n1 + c2)
            {
                Console.WriteLine("Cliente agregado");
            }
            if (n1 + c3)
            {
                Console.WriteLine("Cliente agregado");
            }
            if (n1 + c4)
            {
                Console.WriteLine("Cliente agregado");
            }
            if (n1 + c5)
            {
                Console.WriteLine("Cliente agregado");
            }
            if (n1 + c6)
            {
                Console.WriteLine("Cliente agregado");
            }
            if (n1 + c7)
            {
                Console.WriteLine("Cliente agregado");
            }
            if (n1 + c8)
            {
                Console.WriteLine("Cliente agregado");
            }
            if (n1 + c9)
            {
                Console.WriteLine("Cliente agregado");
            }
            if (n1 + c10)
            {
                Console.WriteLine("Cliente agregado");
            }
            if (n1 + c11)
            {
                Console.WriteLine("Cliente agregado");
            }
            Console.WriteLine("Procesando clientes");
            while(n1.ClientesPendientes > 0)
            {
                if (~n1)
                {
                    Console.WriteLine("Con exito");
                }
            }
        }
    }
}
