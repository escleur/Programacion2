using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza : Botella
    {
        public const int MEDIDA = 330;
        private Tipo tipo;

        public Cerveza(int capacidadML, string marca,Tipo tipo, int contenidoML) : base(marca, capacidadML, contenidoML)
        {
            this.tipo = tipo;

        }

        public Cerveza(int capacidadML, string marca, int contenidoML) : this(capacidadML, marca, Tipo.Vidrio, contenidoML)
        {
         

        }

        public override int ServirMedida()
        {
            int aServir = MEDIDA;
            if(MEDIDA > this.contenidoML)
            {
                aServir = this.contenidoML;
            }

            aServir = aServir * 80 / 100;

            this.contenidoML -= aServir;

            return aServir;
        }

        protected override string GenerarInforme()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Botella de cerveza");
            if(this.tipo == Botella.Tipo.Plastico)
            {
                sb.AppendLine("La botella es de plastico");
            }
            else
            {
                sb.AppendLine("La botella es de vidrio");
            }
            sb.AppendLine($"La medida es {MEDIDA}");
            sb.AppendLine($"{base.GenerarInforme()}");
            return sb.ToString();
        }

        public static implicit operator Botella.Tipo (Cerveza cerveza)
        {
            return cerveza.tipo;
        }





    }



}
