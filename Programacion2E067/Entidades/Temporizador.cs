using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Temporizador
    {
        private Thread hilo;
        private int intervalo;


        public bool Activo
        {
            get
            {
                return !(hilo is null) && hilo.IsAlive;
            }
            set
            {
                if (!this.Activo && value == true)
                {
                    hilo = new Thread(Corriendo);
                    hilo.Start();
                }
                else
                {
                    if (value == false && !(hilo is null))
                    {
                        hilo.Abort();
                    }
                }
            }
        }
        public int Intervalo
        {
            get
            {
                return this.intervalo;
            }
            set
            {
                this.intervalo = value;
            }
        }
        private void Corriendo()
        {
            do
            {
                Thread.Sleep(this.intervalo);
                if(!(this.EventoTiempo is null))
                {
                    this.EventoTiempo.Invoke();

                }
            } while (true);
        }
        public delegate void encargadoTiempo();//object sender, EventArgs e);
        public event encargadoTiempo EventoTiempo;
    }
}
