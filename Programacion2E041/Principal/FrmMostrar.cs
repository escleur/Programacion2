using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace Principal
{
    public partial class FrmMostrar : Form
    {
        Llamada.TipoLlamada tipoLlamada;
        Centralita central;

        public Llamada.TipoLlamada TipoLlamada
        {
            set
            {
                this.tipoLlamada = value;
            }
        }

        public FrmMostrar(Centralita centralita)
        {
            InitializeComponent();
            this.central = centralita;
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            switch (this.tipoLlamada)
            {
                case Llamada.TipoLlamada.Todas:
                    txtMostrar.Text = central.ToString();
                    break;
                case Llamada.TipoLlamada.Local:
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("----------------Totales----------------");
                    sb.AppendLine($"Ganancia local: {central.GananciasPorLocal}");
                    sb.AppendLine("---------------Detalles----------------");
                    foreach (Llamada l in central.Llamadas)
                    {
                        if(l is Local)
                        {
                        sb.AppendLine(l.ToString());
                        }
                    }
                    txtMostrar.Text = sb.ToString();

                    break;
                case Llamada.TipoLlamada.Provincial:
                    StringBuilder sb2 = new StringBuilder();
                    sb2.AppendLine("----------------Totales----------------");
                    sb2.AppendLine($"Ganancia provincial: {central.GananciasPorProvincia}");
                    sb2.AppendLine("---------------Detalles----------------");
                    foreach (Llamada l in central.Llamadas)
                    {
                        if (l is Provincial)
                        {
                            sb2.AppendLine(l.ToString());
                        }
                    }
                    txtMostrar.Text = sb2.ToString();
                    break;
            }
        }
    }
}
