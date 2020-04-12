using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    public class Kelvin
    {
        private double grados;

        public Kelvin(double grados)
        {
            this.grados = grados;
        }
        public double GetGrados()
        {
            return this.grados;
        }

        public static Kelvin operator +(Kelvin k, Fahrenheit f)
        {
            return new Kelvin(k.GetGrados() + ((Kelvin)f).GetGrados());
        }
        public static Kelvin operator +(Kelvin k, Celsius c)
        {
            return new Kelvin(k.GetGrados() + ((Kelvin)c).GetGrados());
        }

        public static Kelvin operator -(Kelvin k, Fahrenheit f)
        {
            return new Kelvin(k.GetGrados() - ((Kelvin)f).GetGrados());
        }
        public static Kelvin operator -(Kelvin k, Celsius c)
        {
            return new Kelvin(k.GetGrados() - ((Kelvin)c).GetGrados());
        }

        public static explicit operator Kelvin(double d)
        {
            return new Kelvin(d);
        }
        public static implicit operator Kelvin(Celsius c)
        {
            return (Kelvin)(Fahrenheit) c;
        }
        public static implicit operator Kelvin(Fahrenheit f)
        {
            return new Kelvin((f.GetGrados() + 459.67) * 5 / 9);
        }

        public static bool operator ==(Kelvin k, Celsius c)
        {
            return (k - c).GetGrados() == 0;
        }
        public static bool operator !=(Kelvin k, Celsius c)
        {
            return !(k == c);
        }
        public static bool operator ==(Kelvin k, Kelvin k2)
        {
            return k.GetGrados() - k2.GetGrados() == 0;
        }
        public static bool operator !=(Kelvin k, Kelvin k2)
        {
            return !(k == k2);
        }
        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            return (k - f).GetGrados() == 0;
        }
        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            return !(k == f);
        }

        override public string ToString()
        {
            return $"La temperatura kelvin es: {this.GetGrados()}";
        }


    }
}
