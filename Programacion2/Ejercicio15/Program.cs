using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculadora.Calcular(19, 25, '+'));
            Console.WriteLine(Calculadora.Calcular(19, 25, '-'));
            Console.WriteLine(Calculadora.Calcular(19, 25, '*'));
            Console.WriteLine(Calculadora.Calcular(19, 25, '/'));
            Console.WriteLine(Calculadora.Calcular(19, 0, '/'));
            Console.ReadKey();
        }
    }

    class Calculadora
    {
        public static double Calcular(double operando1, double operando2, char operacion)
        {
            double resultado = 0;
            switch (operacion)
            {
                case '+':
                    resultado = operando1 + operando2;
                    break;
                case '-':
                    resultado = operando1 - operando2;
                    break;
                case '*':
                    resultado = operando1 * operando2;
                    break;
                case '/':
                    if (Calculadora.Validar(operando2))
                    {
                        resultado = operando1 / operando2;
                    }
                    break;
            }
            return resultado;
        }

        private static bool Validar(double operando2)
        {
            return operando2 != 0;
        }
    }
}
namespace hola
{

}