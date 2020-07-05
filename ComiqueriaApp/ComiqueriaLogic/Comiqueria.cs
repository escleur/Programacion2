using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        List<Producto> productos;
        List<Venta> ventas;

        public Producto this[Guid codigo]
        {
            get
            {
                Producto retorno = null;
                foreach (Producto item in productos)
                {
                    if ((Guid)item == codigo)
                    {
                        retorno = item;
                        break;
                    }
                }
                return retorno
            }
        }
        public Comiqueria()
        {
            productos = new List<Producto>();
            ventas = new List<Venta>();

        }

        public Dictionary<Guid, string> ListarProductos()
        {

        }
        public string ListarVentas()
        {

        }

        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            bool retorno = false;
            foreach (Producto item in comiqueria.productos)
            {
                if (item.Descripcion == producto.Descripcion)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno
        }

        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);
        }

        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            if(!(comiqueria is null) && !(producto is null))
            {
                if(comiqueria != producto)
                {
                    comiqueria.productos.Add(producto);

                }
            }
        }
        public void Vender(Producto producto)
        {

        }

        public void Vender(Producto producto, int cantidad)
        {

        }
    }
}
