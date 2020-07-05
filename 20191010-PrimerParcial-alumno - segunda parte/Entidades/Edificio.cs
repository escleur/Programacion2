using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Edificio
    {
        private Cantina[] cantinas;
        private const short limiteCantinas = 2;
        private static Edificio singleton;

        private Edificio()
        {
            this.cantinas = new Cantina[limiteCantinas];
        }
        static Edificio()
        {
            Edificio.singleton = new Edificio();
        }
        public static Edificio GetBar()
        {
            return Edificio.singleton;
        }
        public static bool operator +(Edificio e, Cantina c)
        {
            bool retorno = false;
            if(!(e is null) && !(c is null))
            {
                for(int i = 0; i < e.cantinas.Count(); i++)
                {
                    if(e.cantinas[i] is null)
                    {
                        e.cantinas[i] = c;
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

    }
}

