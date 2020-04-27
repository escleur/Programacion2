using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class VehiculoDeCarrera
    {
        #region Atributos
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;
        #endregion

        #region Propiedades
        public short CantidadCombustible {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }
        }

        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }

        public string Escuderia
        {
            get
            {
                return this.escuderia;
            }
            set
            {
                this.escuderia = value;
            }
        }

        public short Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }
        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }

        #endregion

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.Numero = numero;
            this.Escuderia = escuderia;

        }
        #region Sobrecarga de operadores
        public static bool operator ==(VehiculoDeCarrera a1, VehiculoDeCarrera a2)
        {
            return a1.Numero == a2.Numero && a1.Escuderia == a2.Escuderia;
        }
        public static bool operator !=(VehiculoDeCarrera a1, VehiculoDeCarrera a2)
        {
            return !(a1 == a2);
        }
        #endregion

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Escuderia: {this.Escuderia}  Numero: {this.Numero}");
            if (this.EnCompetencia)
            {
                sb.AppendLine("Compitiendo");
                sb.AppendLine($"Vueltas restantes: {this.VueltasRestantes}");
                sb.AppendLine($"Cantidad de combustible: {this.CantidadCombustible}");

            }
            return sb.ToString();
        }
    }
}
