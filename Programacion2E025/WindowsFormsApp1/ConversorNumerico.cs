using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace WindowsFormsApp1
{
    public partial class ConversorNumerico : Form
    {
        public ConversorNumerico()
        {
            InitializeComponent();
        }

        private void btnBinToDec_Click(object sender, EventArgs e)
        {
            txtResultadoDec.Text = Conversor.BinarioDecimal(txtBinario.Text).ToString();
        }

        private void btnDecToBin_Click(object sender, EventArgs e)
        {
            if(double.TryParse(txtDecimal.Text, out double numero))
            {
                txtResultadoBin.Text = Conversor.DecimalBinario(numero).ToString();

            }

        }
    }
}
