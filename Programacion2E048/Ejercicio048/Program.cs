using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio048
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> c1 = new Contabilidad<Factura, Recibo>();
            Factura f1 = new Factura(1);
            Recibo r1 = new Recibo(3);

            c1 += f1;
            c1 += r1;


        }
    }
}
