using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Biblioteca
{
    public class PuestoAtencion
    {
        public enum Puesto { caja1, caja2 }
        private static int numeroActual;
        Puesto puesto;

        public int NumeroActual
        {
            get
            {
                PuestoAtencion.numeroActual++;
                return PuestoAtencion.numeroActual;
            }
        }

        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public bool Atender(Cliente cli)
        {
            Console.WriteLine("{0}Atendiendo cliente {1}",this.puesto, cli.ToString());
            Thread.Sleep(5000);
            Console.WriteLine("Atencion finalizada");

            return true;
        }
    }
}
