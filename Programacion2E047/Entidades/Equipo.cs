using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {
        string nombre;
        DateTime fechaCreacion;

        public Equipo(string nombre, DateTime f)
        {
            this.nombre = nombre;
            this.fechaCreacion = f;
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            return (e1.nombre == e2.nombre && e1.fechaCreacion.Date == e2.fechaCreacion.Date);
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

        public string Ficha()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.nombre} fundado el {this.fechaCreacion.Date}");
            return sb.ToString();

        }
    }
}
