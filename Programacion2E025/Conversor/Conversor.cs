using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Conversor
    {
        public static string DecimalBinario(double dec)
        {
            int signo = (dec >= 0) ? 1 : -1;
            int parteEntera = Math.Abs((int)dec);
            double parteDecimal = Math.Abs(dec) - parteEntera;

            string binario = "";

            //Calculo la parte entera del binario con divisiones por 2
            while (parteEntera > 0)
            {
                binario = ((parteEntera % 2 == 1) ? "1" : "0") + binario;
                parteEntera /= 2;
            }

            //Pongo el signo menos si corresponde
            binario = ((signo < 0) ? "-" : "") + binario;

            string binarioFraccion = (parteDecimal == 0) ? "" : ".";
            int presicion = 20;

            //Calculo la parte fraccional con multiplicaciones por 2
            while (parteDecimal != 0 && presicion != 0)
            {
                parteDecimal *= 2;
                binarioFraccion += ((parteDecimal >= 1) ? "1" : "0");
                parteDecimal = parteDecimal - (int)parteDecimal;
                presicion--;
            }

            binario += binarioFraccion;

            return binario;
        }
        public static double BinarioDecimal(string bin)
        {
            double dec = 0;

            int punto = bin.IndexOf('.');

            string binarioFraccion = (punto != -1) ? bin.Substring(punto + 1) : "";

            int signo = (bin.IndexOf('-') != -1) ? -1 : 1;
            if (punto == -1)
                punto = bin.Length;

            //Calcula la parte entera del numero
            for (int i = 0; i < punto; i++)
            {
                if (bin[punto - i - 1] == '1')
                {
                    dec += Math.Pow(2, i);
                }
            }

            //Calcula la parte fraccionaria del numero
            for (int i = 0; i < binarioFraccion.Length; i++)
            {
                if (binarioFraccion[i] == '1')
                {
                    dec += Math.Pow(2, -i - 1);
                }

            }

            dec *= signo;

            return dec;
        }

    }
}
