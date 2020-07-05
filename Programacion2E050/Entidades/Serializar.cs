using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Serializar<S, V> : IGuardar<S, V>
    {
        public bool Guardar(S obj)
        {
            return true;
        }
        public V Leer()
        {
            string msj = "Objeto leido";
            V v = (V)Convert.ChangeType(msj, typeof(V));
            return v;
        }
    }
}

