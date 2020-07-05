using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class GuardarTexto<T,V> : IGuardar<T,V>
    {
        public bool Guardar(T obj)
        {
            return true;
        }
        public V Leer()
        {
            string msj = "Texto Leido";
            V v = (V)Convert.ChangeType(msj, typeof(V));
            return v;
        }
    }
}
