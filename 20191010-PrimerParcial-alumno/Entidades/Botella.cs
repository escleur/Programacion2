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
        
        protected virtual string generarInforme()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Capacidad en litros: {this.CapacidadLitros}");
            sb.AppendLine($"Contenido: {this.Contenido}");
            sb.AppendLine($"Porcentaje: {this.PorcentajeContenido}");
            sb.AppendLine($"Marca: {this.marca}");
            return sb.ToString();


        }
        public override string ToString()
        {
            return this.generarInforme();
        }
    }
}
