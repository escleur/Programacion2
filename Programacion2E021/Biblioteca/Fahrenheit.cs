using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    public class Fahrenheit
    {
        private double grados;

        public Fahrenheit(double grados)
        {
            this.grados = grados;
        }
        public double GetGrados()
        {
            return this.grados;
        }

        public static Fahrenheit operator +(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit(f.GetGrados() + ((Fahrenheit)c).GetGrados());
        }
        public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(f.GetGrados() + ((Fahrenheit)k).GetGrados());
        }

        public static Fahrenheit operator -(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit(f.GetGrados() - ((Fahrenheit)c).GetGrados());
        }
        public static Fahrenheit operator -(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(f.GetGrados() - ((Fahrenheit)k).GetGrados());
        }

        public static explicit operator Fahrenheit(double d)
        {
            return new Fahrenheit(d);
        }
        public static implicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit(c.GetGrados() * 9 / 5 + 32);
        }
        public static implicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit(k.GetGrados() * 9 / 5 - 459.67);
        }

        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            return (f - c).GetGrados() == 0;
        }
        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            return !(f == c);
        }
        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            return (f - k).GetGrados() == 0;
        }
        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            return !(f == k);
        }
        public static bool operator ==(Fahrenheit f, Fahrenheit f2)
        {
            return f.GetGrados() - f2.GetGrados() == 0;
        }
        public static bool operator !=(Fahrenheit f, Fahrenheit f2)
        {
            return !(f == f2);
        }

        override public string ToString()
        {
            return $"La temperatura fahrenheit es: {this.GetGrados()}";
        }

    }
}
