﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada, IGuardar<string>
    {
        protected float costo;

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
                return this.CalcularCosto();
            }
        }

        private float CalcularCosto()
        {

            return this.costo * this.duracion;
        }
        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }
        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this.costo = costo;
        }
        public override bool Equals(object obj)
        {
            return obj is Local;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo por minuto: {this.costo}");
            sb.AppendLine($"Costo llamada {this.CostoLlamada}");
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
