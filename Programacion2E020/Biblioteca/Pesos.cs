using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Pesos()
        {
            cotizRespectoDolar = 0.015365937497;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizacion) : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }

        public static Pesos operator +(Pesos p1, Pesos p2)
        {
            return new Pesos(p1.GetCantidad() + p2.GetCantidad());
        }
        public static Pesos operator +(Pesos p1, Dolar d2)
        {
            return new Pesos(p1.GetCantidad() + ((Pesos)d2).GetCantidad());
        }
        public static Pesos operator +(Pesos p1, Euro e2)
        {
            return new Pesos(p1.GetCantidad() + ((Pesos)e2).GetCantidad());
        }

        public static Pesos operator -(Pesos p1, Pesos p2)
        {
            return new Pesos(p1.GetCantidad() - p2.GetCantidad());
        }
        public static Pesos operator -(Pesos p1, Dolar d2)
        {
            return new Pesos(p1.GetCantidad() - ((Pesos)d2).GetCantidad());
        }
        public static Pesos operator -(Pesos p1, Euro e2)
        {
            return new Pesos(p1.GetCantidad() - ((Pesos)e2).GetCantidad());
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return p1.GetCantidad() == p2.GetCantidad();
        }
        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Pesos p1, Dolar d2)
        {
            return (p1 - d2).GetCantidad() == 0;
        }
        public static bool operator !=(Pesos p1, Dolar d2)
        {
            return !(p1 == d2);
        }
        public static bool operator ==(Pesos p1, Euro e2)
        {
            return (p1 - e2).GetCantidad() == 0;
        }
        public static bool operator !=(Pesos p1, Euro e2)
        {
            return !(p1 == e2);
        }

        public static implicit operator Pesos(double p)
        {
            return new Pesos(p);
        }
        public static explicit operator Dolar(Pesos p)
        {
            return p.GetCantidad() * Pesos.GetCotizacion();
        }
        public static explicit operator Euro(Pesos p)
        {
            return (Euro)(Dolar)p;
        }

        override public string ToString()
        {
            return $"Cantidad de Pesos: {this.GetCantidad()}";
        }

    }
}
