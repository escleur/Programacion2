using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;

namespace Conversor
{
    public partial class Conversor : Form
    {
        public Conversor()
        {
            InitializeComponent();
            txtCotizacionEuro.Text = Euro.GetCotizacion().ToString();
            txtCotizacionDolar.Text = Dolar.GetCotizacion().ToString();
            txtCotizacionPeso.Text = Pesos.GetCotizacion().ToString();
        }


        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {
            btnLockCotizacion.ImageIndex = (btnLockCotizacion.ImageIndex == 1) ? 0 : 1;
            if (btnLockCotizacion.ImageIndex == 1)
            {
                txtCotizacionDolar.Enabled = false;
                txtCotizacionEuro.Enabled = false;
                txtCotizacionPeso.Enabled = false;
            }
            else
            {
                txtCotizacionDolar.Enabled = true;
                txtCotizacionEuro.Enabled = true;
                txtCotizacionPeso.Enabled = true;
            }
        }

        private void txtCotizacionEuro_Leave(object sender, EventArgs e)
        {
            if(double.TryParse(txtCotizacionEuro.Text, out double euro))
            {
                Euro.SetCotizacion(euro);
            }
            else
            {
                txtCotizacionEuro.Focus();
            }
        }

        private void txtCotizacionDolar_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(txtCotizacionDolar.Text, out double dolar))
            {
                Dolar.SetCotizacion(dolar);
            }
            else
            {
                txtCotizacionDolar.Focus();
            }

        }

        private void txtCotizacionPeso_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(txtCotizacionPeso.Text, out double peso))
            {
                Pesos.SetCotizacion(peso);
            }
            else
            {
                txtCotizacionPeso.Focus();
            }

        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtEuro.Text,out double euroNumero))
            {
                Euro euro = new Euro(euroNumero);
                txtEuroAEuro.Text = euro.ToString();
                txtEuroADolar.Text = ((Dolar)euro).ToString();
                txtEuroAPeso.Text = ((Pesos)euro).ToString();
            }
            else
            {
                txtEuroAEuro.Text = "";
                txtEuroADolar.Text = "";
                txtEuroAPeso.Text = "";
            }
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDolar.Text, out double dolarNumero))
            {
                Dolar dolar = new Dolar(dolarNumero);
                txtDolarADolar.Text = dolar.ToString();
                txtDolarAEuro.Text = ((Euro)dolar).ToString();
                txtDolarAPeso.Text = ((Pesos)dolar).ToString();
            }
            else
            {
                txtDolarAEuro.Text = "";
                txtDolarADolar.Text = "";
                txtDolarAPeso.Text = "";
            }

        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPeso.Text, out double pesoNumero))
            {
                Pesos peso = new Pesos(pesoNumero);
                txtPesoAPeso.Text = peso.ToString();
                txtPesoADolar.Text = ((Dolar)peso).ToString();
                txtPesoAEuro.Text = ((Euro)peso).ToString();
            }
            else
            {
                txtPesoAEuro.Text = "";
                txtPesoADolar.Text = "";
                txtPesoAPeso.Text = "";
            }

        }
    }
}
