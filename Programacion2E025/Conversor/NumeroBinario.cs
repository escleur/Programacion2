using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class NumeroBinario
    {
        private string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }
        public NumeroBinario():this("")
        {

        }
        public static string operator +(NumeroBinario b, NumeroDecimal d)
        {
            return Conversor.DecimalBinario(Conversor.BinarioDecimal(b.numero) + d.Numero); 
        }
        public static string operator -(NumeroBinario b, NumeroDecimal d)
        {
            return Conversor.DecimalBinario(Conversor.BinarioDecimal(b.numero) - d.Numero);
        }
        public static bool operator ==(NumeroBinario b, NumeroDecimal d)
        {
            return (Conversor.BinarioDecimal(b.numero) - d.Numero) == 0;
        }

        public static bool operator !=(NumeroBinario b, NumeroDecimal d)
        {
            return !(b == d);
        }

        public static implicit operator NumeroBinario(string s)
        {
            return new NumeroBinario(s);
        }
        public static explicit operator string(NumeroBinario s)
        {
            return s.numero;
        }

    }
}
