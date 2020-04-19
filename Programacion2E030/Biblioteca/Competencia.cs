using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Competencia
    {
        private static Random random = new Random();
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool seAgrego = false;
            if (c.competidores.Count() < c.cantidadCompetidores)
            {
                if (c != a)//lo agrego
                {
                    a.SetEnCompetencia(true);
                    a.SetVueltasRestantes(c.cantidadVueltas);
                    a.SetCantidadCombustible((short)random.Next(15, 100));
                    c.competidores.Add(a);
                    seAgrego = true;
                }
            }

            return seAgrego;
        }
        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool seQuito = false;
            if (c == a)//lo quito
            {
                for(int i = 0; i < c.competidores.Count(); i++)
                {
                    if (c.competidores[i] == a)
                    {
                        c.competidores.RemoveAt(i);
                    }
                }                
                a.SetEnCompetencia(false);
                a.SetVueltasRestantes(0);
                seQuito = true;
            }

            return seQuito;
        }



        public static bool operator ==(Competencia c, AutoF1 a)
        {
            bool estabaElAuto = false;
            foreach (AutoF1 item in c.competidores)
            {
                if (item == a)
                {
                    estabaElAuto = true;
                    break;
                }
            }
            return estabaElAuto;
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Competencia ");
            sb.AppendLine($"Cantidad de vueltas: {this.cantidadVueltas}");
            sb.AppendLine($"Cantidad de competidores: {this.cantidadCompetidores}");
            foreach (AutoF1 auto in this.competidores)
            {
                sb.AppendLine("Auto:");
                sb.AppendLine(auto.MostrarDatos());
            }
            return sb.ToString();

        }

    }
}
