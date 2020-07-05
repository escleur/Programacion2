using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public abstract class Botella
    {

        public enum Tipo { Plastico, Vidrio}
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;

        protected Botella(string marca, int capacidadML, int contenidoML)
        {
            this.marca = marca;
            this.capacidadML = capacidadML;
            if (contenidoML > capacidadML)
            {
                this.contenidoML = capacidadML;
            }
            else
            {
                this.contenidoML = contenidoML;
            }

            
        }

        /// <summary>
        /// 
        /// </summary>
        public int CapacidadLitros
        {
            get
            {
                return this.capacidadML/1000;
            }
        }


        public int Contenido
        {
            get
            {
                return this.contenidoML;
            }
            set
            {
                this.contenidoML = value;
            }
        }

        public float PorcentajeContenido
        {
            get
            {
                return (float)this.contenidoML * 100 / this.capacidadML;
            }
        }

        public abstract int ServirMedida();
        
        protected virtual string GenerarInforme()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Capacidad en litros: {0}", this.CapacidadLitros));
            sb.AppendLine($"Contenido: {this.Contenido}");
            sb.AppendLine($"Porcentaje: {this.PorcentajeContenido}");
            sb.AppendLine($"Marca: {this.marca}");
            return sb.ToString();


        }
        public static implicit operator string(Botella b)
        {
            return b.GenerarInforme();
        }


        public static bool operator ==(Botella b1, Botella b2)
        {
            return (b1.marca == b2.marca);
        }

        public static bool operator !=(Botella b1, Botella b2)
        {
            return !(b1 == b2);
        }

    }
}
