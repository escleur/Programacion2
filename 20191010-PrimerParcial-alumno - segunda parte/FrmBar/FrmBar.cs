using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FrmBar
{
    public partial class FrmBar : Form
    {
        Edificio edificio;

        public FrmBar()
        {
            InitializeComponent();
            edificio = Edificio.GetBar();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCantidadEspaciosCantina frmCant = new FrmCantidadEspaciosCantina();
            if(frmCant.ShowDialog() == DialogResult.OK)
            {
                FrmCantina cantina = new FrmCantina(frmCant.CantidadEspacios);
                if(this.edificio + cantina.GetCantina())
                {
                    cantina.MdiParent = this;
                    cantina.Show();
                }
            }
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
