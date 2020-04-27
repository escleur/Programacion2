using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincia
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listaDeLlamadas.Add(nuevaLlamada);
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float sumador = 0;
            foreach(Llamada l in this.listaDeLlamadas)
            {
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if (l is Local)
                        {
                            sumador += l.CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if (l is Provincial)
                        {
                            sumador += l.CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Todas:
                        if (l is Local)
                        {
                            sumador += l.CostoLlamada;
                        }
                        if (l is Provincial)
                        {
                            sumador += l.CostoLlamada;
                        }
                        break;
                }
            }
            return sumador;
        }

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
            this.razonSocial = "";
        }
        public Centralita(string nombreEmpresa) : this ()
        {
            this.razonSocial = nombreEmpresa;
        }
        
        public static bool operator ==(Centralita c, Llamada l)
        {
            bool esta = false;
            foreach(Llamada item in c.Llamadas)
            {
                if(item == l)
                {
                    esta = true;
                    break;
                }
            }
            return esta;
        }
        public static bool operator !=(Centralita c, Llamada l)
        {
            return !(c == l);
        }

        public static Centralita operator +(Centralita c, Llamada l)
        {
            if (c != l)
            {
                c.AgregarLlamada(l);
            }
            return c;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----------------Totales----------------");
            sb.AppendLine($"Razon social: {this.razonSocial}");
            sb.AppendLine($"Ganancia total: {this.GananciasPorTotal}");
            sb.AppendLine($"Ganancia provincial: {this.GananciasPorProvincia}");
            sb.AppendLine($"Ganancia local: {this.GananciasPorLocal}");
            sb.AppendLine("---------------Detalles----------------");
            foreach (Llamada l in this.Llamadas)
            {
                    sb.AppendLine(l.ToString());
            }
            return sb.ToString();

        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

    }
}
