using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Euro
    {
        #region Atributos
        private double cantidad;
        private static double cotizRespectoDolar;
        #endregion

        #region Constructores
        static Euro()
        {
            cotizRespectoDolar = 1.0867084687191;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Getters, Setters
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }
        public static void SetCotizacion(double cotizacion)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Sobrecarga operadores +,-
        public static Euro operator +(Euro e1, Euro e2)
        {
            return new Euro(e1.GetCantidad() + e2.GetCantidad());
        }
        public static Euro operator +(Euro e1, Dolar d2)
        {
            return new Euro(e1.GetCantidad() + ((Euro)d2).GetCantidad());
        }
        public static Euro operator +(Euro e1, Pesos p2)
        {
            return new Euro(e1.GetCantidad() + ((Euro)p2).GetCantidad());
        }

        public static Euro operator -(Euro e1, Euro e2)
        {
            return new Euro(e1.GetCantidad() - e2.GetCantidad());
        }
        public static Euro operator -(Euro e1, Dolar d2)
        {
            return new Euro(e1.GetCantidad() - ((Euro)d2).GetCantidad());
        }
        public static Euro operator -(Euro e1, Pesos p2)
        {
            return new Euro(e1.GetCantidad() - ((Euro)p2).GetCantidad());
        }
        #endregion

        #region Sobrecarga operadores ==,!=
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.GetCantidad() == e2.GetCantidad();
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
        public static bool operator ==(Euro e1, Dolar d2)
        {
            return (e1 - d2).GetCantidad() == 0;
        }
        public static bool operator !=(Euro e1, Dolar d2)
        {
            return !(e1 == d2);
        }
        public static bool operator ==(Euro e1, Pesos p2)
        {
            return (e1 - p2).GetCantidad() == 0;
        }
        public static bool operator !=(Euro e1, Pesos p2)
        {
            return !(e1 == p2);
        }
        #endregion

        #region Conversiones
        public static implicit operator Euro(double e)
        {
            return new Euro(e);
        }
        public static explicit operator Dolar(Euro e)
        {
            return e.GetCantidad() * Euro.GetCotizacion();
        }
        public static explicit operator Pesos(Euro e)
        {
            return (Pesos)(Dolar)e;
        } 
        #endregion

        override public string ToString()
        {
            return $"{this.GetCantidad()}";
        }

    }
}
