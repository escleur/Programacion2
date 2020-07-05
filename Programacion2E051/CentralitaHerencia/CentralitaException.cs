using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class CentralitaException : Exception
    {
        string nombreClase;
        string nombreMetodo;



        public string NombreClase
        {
            get
            {
                return this.nombreClase;
            }
        }
        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }
        }

        public CentralitaException(string mensaje, string clase, string metodo)
            : base(mensaje)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }
        public CentralitaException(string mensaje, string clase, string metodo, Exception innerException)
            : base(metodo, innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;

        }
    }
}
