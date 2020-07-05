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
    public partial class FrmMenu : Form
    {
        Centralita centralita;

        public FrmMenu()
        {
            InitializeComponent();
            centralita = new Centralita();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador fl = new FrmLlamador(this.centralita);
            fl.ShowDialog();
            this.centralita = fl.central;
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar fm = new FrmMostrar(this.centralita);
            fm.TipoLlamada = Llamada.TipoLlamada.Todas;
            fm.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar fm = new FrmMostrar(this.centralita);
            fm.TipoLlamada = Llamada.TipoLlamada.Local;
            fm.ShowDialog();

        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar fm = new FrmMostrar(this.centralita);
            fm.TipoLlamada = Llamada.TipoLlamada.Provincial;
            fm.ShowDialog();

        }
    }
}
