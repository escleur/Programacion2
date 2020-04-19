using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        string nombre;

        public Cliente Cliente
        {
            get
            {
                return clientes.Dequeue();
            }
            set
            {
                if (this != value)
                {
                    this.clientes.Enqueue(value);
                }
            }
        }
        public int ClientesPendientes
        {
            get
            {
                return clientes.Count;
            }
        }
        private Negocio()
        {
            clientes = new Queue<Cliente>();
            caja = new PuestoAtencion(PuestoAtencion.Puesto.caja1);
        }
        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            bool seEncuentra = false;
            foreach (Cliente item in n.clientes)
            {
                if (item == c)
                {
                    seEncuentra = true;
                    break;
                }
            }
            return seEncuentra;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool retorno = false;
            if (n != c)
            {
                n.clientes.Enqueue(c);
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ~(Negocio n)
        {
            bool retorno = false;
            if (n.ClientesPendientes > 0)
            {
                retorno = n.caja.Atender(n.Cliente);

            }
            return retorno;
        }


    }
}
