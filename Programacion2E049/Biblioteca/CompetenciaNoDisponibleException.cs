using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CompetenciaNoDisponibleException : Exception
    {
        string nombreClase;
        string nombreMetodo;

        public string NombreClase
        {
            get
            {
                return nombreClase;
            }
        }
        public string NombreMetodo
        {
            get
            {
                return nombreMetodo;
            }
        }
        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo)
            : this(mensaje,clase,metodo,null)
        {

        }
        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException)
            : base(mensaje, innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Excepcion en el metodo {this.NombreMetodo} de la clase {this.NombreClase}");
            sb.AppendLine($"{this.Message}");
            Exception e = this.InnerException;
            while (e != null)
            {
                sb.Append($"{e.Message}\t");
                e = e.InnerException;
            }
            return sb.ToString();
        }
    }
}
