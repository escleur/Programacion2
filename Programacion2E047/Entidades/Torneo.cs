using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Torneo<T> where T : Equipo//, new()
    {
        List<T> equipos;
        string nombre;
        static Random r;

        public Torneo(string nombre)
        {
            equipos = new List<T>();
            this.nombre = nombre;
        }
        static Torneo()
        {
            r = new Random();
        }

        public static bool operator ==(Torneo<T> t, T e)
        {
            bool retorno = false;
            foreach (T item in t.equipos)
            {
                if(item == e)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Torneo<T> t, T e)
        {
            return !(t == e);
        }

        public static bool operator +(Torneo<T> t, T e)
        {
            bool retorno = false; 
            if(t != e)
            {
                t.equipos.Add(e);
                retorno = true;
            }
            return retorno;
        }
        public string Mostrar()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre de torneo: {this.nombre}");
            foreach (T item in equipos)
            {
                sb.AppendLine($"{item.Ficha()}");

            }
            return sb.ToString();


        }
        string CalcularPartido(T e1, T e2)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append($"{e1.Nombre} {r.Next(0,6)}");
            sb.AppendLine($"{e2.Nombre} {r.Next(0,6)}");
            return sb.ToString();
        }

        public string JugarPartido
        {
            get
            {
                int index1 = r.Next(0, equipos.Count);
                int index2 = r.Next(0, equipos.Count);
                while(equipos.Count >= 2 && index1 == index2)
                {
                    index2 = r.Next(0, equipos.Count - 1);

                }
                return CalcularPartido(equipos[index1], equipos[index2]);
            }
        }

    }
}
