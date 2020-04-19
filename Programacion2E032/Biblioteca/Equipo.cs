using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        #region Constructores
        private Equipo()
        {
            jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        } 
        #endregion
        public static bool operator +(Equipo e, Jugador j)
        {
            bool equipoContieneJugador = false;
            bool agregoJugador = false;
            if (e.jugadores.Count < e.cantidadDeJugadores)
            {
                foreach (Jugador jugador in e.jugadores)
                {
                    if (j == jugador)
                    {
                        equipoContieneJugador = true;
                        break;
                    }
                }
                if (!equipoContieneJugador)
                {
                    agregoJugador = true;
                    e.jugadores.Add(j);
                }

            }
            return agregoJugador;
        }
    }
}
