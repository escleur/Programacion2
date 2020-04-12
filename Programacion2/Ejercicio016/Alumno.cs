using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio016
{
    class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;
        static Random rnd = new Random();

        public Alumno()
        {
            notaFinal = -1;
        }
        public void CalcularFinal()
        {

            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                this.notaFinal = rnd.Next(4, 10);
            }
        }
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }
        public string Mostrar()
        {
            string retorno = $"Nombre: {nombre} Apellido: {apellido} Legajo: {legajo} Nota 1: {nota1} Nota 2: {nota2} Nota final:";
            if(notaFinal != -1)
            {
                retorno += $" {notaFinal}";
            }
            else
            {
                retorno += " Alumno desaprobado";
            }
            return retorno;
        }
    }
}
