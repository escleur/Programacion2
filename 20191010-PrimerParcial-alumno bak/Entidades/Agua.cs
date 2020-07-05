using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Agua : Botella
    {
        public const int MEDIDA = 400;


        public int ServirMedida(int medida)
        {
            int aServir = medida;
            if (medida > this.contenidoML)
            {
                aServir = this.contenidoML;
            }

            this.contenidoML -= aServir;

            return aServir;

        }

        public override int ServirMedida()
        {
            return this.ServirMedida(MEDIDA);
        }

        public Agua(int capacidadML, string marca, int contenidoML) : base( marca, capacidadML, contenidoML)
        { 

        }


        protected string GenerarInforme()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Botella de agua");
            sb.AppendLine($"{base.ToString()}");
            return sb.ToString();
        }



    }
}
