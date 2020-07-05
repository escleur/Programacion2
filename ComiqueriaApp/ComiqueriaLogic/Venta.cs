using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public sealed class Venta
    {
        DateTime fecha;
        static int porcentajeIva;
        double precioFinal;
        Producto producto;


        internal DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
        }

        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double total = precioUnidad * cantidad;
            total += total * Venta.porcentajeIva / 100;
            return total;
        }

        string ObetenerDescripcionBreve()
        {

            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.fecha}");
            sb.Append($" - {this.producto.Descripcion}");
            sb.AppendFormat(" - {0:C2}", this.precioFinal);
            return sb.ToString();
        }

        void Vender(int cantidad)
        {
            this.producto.Stock -= cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = Venta.CalcularPrecioFinal(this.producto.Precio, cantidad);
        }

        static Venta()
        {
            Venta.porcentajeIva = 21;
        }

        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.Vender(cantidad);
        }
    }
}
