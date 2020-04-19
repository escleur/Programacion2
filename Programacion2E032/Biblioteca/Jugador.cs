using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Jugador
    {
        #region Atributos
        private int dni;
        private string nombre;
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
        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
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

        #endregion



        #region Constructores
        private Jugador()
        {
            this.Dni = 0;
            this.Nombre = "";
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }
        public Jugador(int dni, string nombre) : this()
        {
            this.Dni = dni;
            this.Nombre = nombre;
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        } 
        #endregion


        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Dni: {this.Dni}");
            sb.AppendLine($"Nombre: {this.Nombre}");
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
