using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        #region Atributos
        private int partidosJugados;
        private int totalGoles;

        public int PartidosJugados {
            get
            {
                return this.partidosJugados;
            }
        }
        public float PromedioGoles
        {
            get
            {
                if (this.partidosJugados > 0)
                {
                    return (float)this.TotalGoles / this.PartidosJugados;
                }
                else
                {
                    return 0;
                }
            }
        }
        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
        }

        #endregion



        #region Constructores
        private Jugador() : base(0, "")
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }
        public Jugador(int dni, string nombre) : this(dni, nombre, 0 ,0)
        {
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : base(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        } 
        #endregion


        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Partidos jugados: {this.PartidosJugados}");
            sb.AppendLine($"Promedio de goles: {PromedioGoles}");
            sb.AppendLine($"Total Goles: {this.TotalGoles}");
            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

    }
}
