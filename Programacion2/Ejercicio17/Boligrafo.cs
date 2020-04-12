using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{

    class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            int retorno = gasto;
            if (this.GetTinta() < retorno)
            {
                retorno = this.GetTinta();
            }
            this.SetTinta((short)-gasto);

            dibujo = "";

            for(int i=0; i<retorno; i++)
            {
                dibujo += "*";
            }
            return this.GetTinta() > 0;
        }

        public void Recargar()
        {
            this.SetTinta(Boligrafo.cantidadTintaMaxima);
        }

        private void SetTinta(short tinta)
        {
            this.tinta += tinta;
            if (this.tinta < 0)
            {
                this.tinta = 0;
            }
            if (this.tinta > Boligrafo.cantidadTintaMaxima)
            {
                this.tinta = Boligrafo.cantidadTintaMaxima;
            }
        }


    }
}
