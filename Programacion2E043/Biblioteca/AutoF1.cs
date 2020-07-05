using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class AutoF1 : VehiculoDeCarrera
    {

        private short caballosDeFuerza;

        public short CaballosDeFuerza
        {
            get
            {
                return this.caballosDeFuerza;
            }
            set
            {
                this.caballosDeFuerza = value;
            }
        }

        #region Constructores
        public AutoF1(short numero, string escuderia) : base(numero, escuderia)
        {

        }
        public AutoF1(short numero, string escuderia, short caballosDeFuerza) : this(numero, escuderia)
        {
            this.CaballosDeFuerza = caballosDeFuerza;
        }


        #endregion

        #region Sobrecarga de operadores
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (VehiculoDeCarrera)a1 == (VehiculoDeCarrera)a2
                && a1.CaballosDeFuerza == a2.CaballosDeFuerza;
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
        #endregion


        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Caballos de fuerza: {this.CaballosDeFuerza}");
            return sb.ToString();
        
        }
    }
}
