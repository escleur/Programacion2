using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Dolar
    {

        #region Atributos
        private double cantidad;
        private static double cotizRespectoDolar;
        #endregion

        #region Constructores
        static Dolar()
        {
            cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Getters, Setters
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }
        public static void SetCotizacion(double cotizacion)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }

        #endregion

        #region Sobrecarga operadores +,-
        public static Dolar operator +(Dolar d1, Dolar d2)
        {
            return new Dolar(d1.GetCantidad() + d2.GetCantidad());
        }
        public static Dolar operator +(Dolar d1, Euro e2)
        {
            return new Dolar(d1.GetCantidad() + ((Dolar)e2).GetCantidad());
        }
        public static Dolar operator +(Dolar d1, Pesos p2)
        {
            return new Dolar(d1.GetCantidad() + ((Dolar)p2).GetCantidad());
        }

        public static Dolar operator -(Dolar d1, Dolar d2)
        {
            return new Dolar(d1.GetCantidad() - d2.GetCantidad());
        }
        public static Dolar operator -(Dolar d1, Euro e2)
        {
            return new Dolar(d1.GetCantidad() - ((Dolar)e2).GetCantidad());
        }
        public static Dolar operator -(Dolar d1, Pesos p2)
        {
            return new Dolar(d1.GetCantidad() - ((Dolar)p2).GetCantidad());
        }
        #endregion

        #region Sobrecarga operadores ==,!=
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.GetCantidad() == d2.GetCantidad();
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }
        public static bool operator ==(Dolar d1, Euro e2)
        {
            return (d1 - e2).GetCantidad() == 0;
        }
        public static bool operator !=(Dolar d1, Euro e2)
        {
            return !(d1 == e2);
        }
        public static bool operator ==(Dolar d1, Pesos p2)
        {
            return (d1 - p2).GetCantidad() == 0;
        }
        public static bool operator !=(Dolar d1, Pesos p2)
        {
            return !(d1 == p2);
        }
        #endregion

        #region Conversiones
        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }
        public static explicit operator Euro(Dolar d)
        {
            return d.GetCantidad() / Euro.GetCotizacion();
        }
        public static explicit operator Pesos(Dolar d)
        {
            return d.GetCantidad() / Pesos.GetCotizacion();
        } 
        #endregion

        override public string ToString()
        {
            return $"{this.GetCantidad()}";
        }
    }
}
