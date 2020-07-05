using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Contabilidad<T,U> where T : Documento where U : Documento, new()
    {
        private List<T> egresos;
        private List<U> ingresos;

        public Contabilidad()
        {
            egresos = new List<T>();
            ingresos = new List<U>();
            
        }
        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, T t)
        {
            c.egresos.Add(t);
            return c;
        }
        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U u)
        {
            c.ingresos.Add(u);
            return c;
        }
    }
}
