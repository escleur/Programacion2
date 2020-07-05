using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Cantina
    {
        private List<Botella> botellas;

        private int espaciosTotales;
//        static Cantina singleton;


        public List<Botella> Botellas
        {
            get
            {
                return this.botellas;
            }
        }

        public Cantina(int espacios)
        {
            botellas = new List<Botella>();
            this.espaciosTotales = espacios;
        }


        public static bool operator ==(Cantina c, Botella b)
        {
            bool retorno = false;
            foreach(Botella item in c.botellas)
            {
                if(item == b)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Cantina c, Botella b)
        {
            return !(c == b);
        }


        /*        public static Cantina GetCantina(int espacios)
                {
                    if(singleton is null)
                    {
                        singleton = new Cantina(espacios);
                    }
                    else
                    {
                        singleton.espaciosTotales = espacios;
                    }
                    return singleton;
                }*/

        public static bool operator +(Cantina c, Botella b)
        {
            bool retorno = false;
            if(c.Botellas.Count < c.espaciosTotales)
            {
                retorno = true;
                c.Botellas.Add(b);
            }
            return retorno;
        }
        public string GetInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cantina:");
            foreach(Botella botella in this.botellas)
            {
                sb.AppendLine((string)botella);
            }
            return sb.ToString();
        }
    }
}
