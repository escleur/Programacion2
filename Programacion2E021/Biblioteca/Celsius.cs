using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    public class Celsius
    {
        private double grados;

        public Celsius(double grados)
        {
            this.grados = grados;
        }
        public double GetGrados()
        {
            return this.grados;
        }

        public static Celsius operator +(Celsius c, Fahrenheit f)
        {
            return new Celsius(c.GetGrados() + ((Celsius)f).GetGrados());
        }
        public static Celsius operator +(Celsius c, Kelvin k)
        {
            return new Celsius(c.GetGrados() + ((Celsius)k).GetGrados());
        }

        public static Celsius operator -(Celsius c, Fahrenheit f)
        {
            return new Celsius(c.GetGrados() - ((Celsius)f).GetGrados());
        }
        public static Celsius operator -(Celsius c, Kelvin k)
        {
            return new Celsius(c.GetGrados() - ((Celsius)k).GetGrados());
        }

        public static explicit operator Celsius(double d)
        {
            return new Celsius(d);
        }
        public static implicit operator Celsius(Fahrenheit f)
        {
            return new Celsius((f.GetGrados() - 32) * 5 / 9);
        }
        public static implicit operator Celsius(Kelvin k)
        {
            return (Celsius)(Fahrenheit)k;
        }

        public static bool operator ==(Celsius c, Celsius c2)
        {
            return c.GetGrados() - c2.GetGrados() == 0;
        }
        public static bool operator !=(Celsius c, Celsius c2)
        {
            return !(c == c2);
        }
        public static bool operator ==(Celsius c, Kelvin k)
        {
            return (c - k).GetGrados() == 0;
        }
        public static bool operator !=(Celsius c, Kelvin k)
        {
            return !(c == k);
        }
        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            return (c - f).GetGrados() == 0;
        }
        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            return !(c == f);
        }



        override public string ToString()
        {
            return $"La temperatura celsius es: {this.GetGrados()}";
        }
    }
}
