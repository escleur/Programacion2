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
    public partial class FrmLlamador : Form
    {
        Centralita centralita;
        static Random random = new Random();

        public Centralita central
        {
            get
            {
                return this.centralita;
            }
        }

        public FrmLlamador(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
            // Carga
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = string.Empty;
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "1";

        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "2";

        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "3";

        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "4";

        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "5";

        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "6";

        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "7";

        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "8";

        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "9";

        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "0";

        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "*";

        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "#";

        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            if(txtNroDestino.Text.Count() >= 1 && txtNroDestino.Text[0] == '#')
            {
                cmbFranja.Enabled = true;
            }
            else
            {
                cmbFranja.Enabled = false;
            }
            if(txtNroDestino.Text.Count() >= 1 && txtNroOrigen.Text.Count() >= 1)
            {
                btnLlamar.Enabled = true;
            }
            else
            {
                btnLlamar.Enabled = false;

            }
        }

        private void txtNroOrigen_TextChanged(object sender, EventArgs e)
        {
            if (txtNroDestino.Text.Count() >= 1 && txtNroOrigen.Text.Count() >= 1)
            {
                btnLlamar.Enabled = true;
            }
            else
            {
                btnLlamar.Enabled = false;

            }

        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNroDestino.Text[0] == '#')
                {
                    Provincial.Franja franja;
                    Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franja);
                    Provincial lp = new Provincial(txtNroOrigen.Text, franja, random.Next(1, 50), txtNroDestino.Text);
                    centralita += lp;
                }
                else
                {
                    Local ll = new Local(txtNroOrigen.Text, random.Next(1, 50), txtNroDestino.Text, random.Next(5, 56) / 10f);
                    centralita += ll;
                }

            }catch(CentralitaException exc)
            {
                MessageBox.Show("La llamada ya existia.");
            }
            btnLlamar.Enabled = false;
            System.Threading.Thread.Sleep(5000);
            txtNroDestino.Text = "";

        }
    }
}
