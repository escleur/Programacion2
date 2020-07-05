using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Producto
    {
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;


        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
        }


        public double Precio
        {
            get
            {
                return this.precio;
            }
        }


        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if(this.stock >= 0)
                {
                    this.stock = value;
                }
            }
        }
        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }
        protected Producto(string descripcion, int stock, double precio)
        {
            this.codigo = Guid.NewGuid();
            this.descripcion = descripcion;
            this.stock = stock;
            this.precio = precio;
        }
        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Descripcion: {this.Descripcion}");
            sb.AppendLine($"Codigo: {this.codigo}");
            sb.AppendLine($"Precio: {this.precio}");
            sb.AppendLine($"Stock: {this.stock}");
            return sb.ToString();
        }
    }
}
