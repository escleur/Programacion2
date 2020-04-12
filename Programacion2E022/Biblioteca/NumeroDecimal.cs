using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class NumeroDecimal
    {
        private double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }
        public NumeroDecimal():this(0)
        {
        }

        public double Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public static double operator +(NumeroDecimal d, NumeroBinario b)
        {
            return Conversor.BinarioDecimal(b + d);
        }
        public static double operator -(NumeroDecimal d, NumeroBinario b)
        {
            return Conversor.BinarioDecimal(b - d);
        }
        public static bool operator ==(NumeroDecimal d, NumeroBinario b)
        {
            return b == d;
        }

        public static bool operator !=(NumeroDecimal d, NumeroBinario b)
        {
            return !(d == b);
        }

        public static implicit operator NumeroDecimal(double n)
        {
            return new NumeroDecimal(n);
        }
        public static explicit operator double (NumeroDecimal n)
        {
            return n.Numero;
        }

    }
}
