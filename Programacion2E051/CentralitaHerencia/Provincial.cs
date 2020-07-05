﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada, IGuardar<string>
    {
        public enum Franja { Franja_1, Franja_2, Franja_3 };

        protected Franja franjaHoraria;

        public string RutadeArchivo
        {
            get
            {
                return "";
            }
            set
            {

            }
        }

        public bool Guardar()
        {
            throw new NotImplementedException();
        }
        public string Leer()
        {
            throw new NotImplementedException();

        }



        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            float costoFranja = 0;
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    costoFranja = 0.99f;
                    break;
                case Franja.Franja_2:
                    costoFranja = 1.25f;
                    break;
                case Franja.Franja_3:
                    costoFranja = 0.66f;
                    break;
            }
            return (float)costoFranja * this.Duracion;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo de la llamada: {this.CostoLlamada}");
            sb.AppendLine($"Franja horaria {this.franjaHoraria}");
            return sb.ToString();

        }

        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
