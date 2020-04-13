using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temperatura;

namespace Conversor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertFahrenheit_Click(object sender, EventArgs e)
        {
            if(double.TryParse(txtFahrenheit.Text, out double fahrenheitNumero))
            {
                Fahrenheit fahrenheit = new Fahrenheit(fahrenheitNumero);
                txtFahrenheitAFahrenheit.Text = fahrenheit.ToString();
                txtFahrenheitACelsius.Text = ((Celsius)fahrenheit).ToString();
                txtFahrenheitAKelvin.Text = ((Kelvin)fahrenheit).ToString();
            }
            else
            {
                txtFahrenheitAFahrenheit.Text = ""; 
                txtFahrenheitACelsius.Text = "";
                txtFahrenheitAKelvin.Text = "";        
            }
        }

        private void btnConvertCelsius_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCelsius.Text, out double celsiusNumero))
            {
                Celsius celsius = new Celsius(celsiusNumero);
                txtCelsiusACelsius.Text = celsius.ToString();
                txtCelsiusAFahrenheit.Text = ((Fahrenheit)celsius).ToString();
                txtCelsiusAKelvin.Text = ((Kelvin)celsius).ToString();
            }
            else
            {
                txtCelsiusAFahrenheit.Text = "";
                txtCelsiusACelsius.Text = "";
                txtCelsiusAKelvin.Text = "";
            }

        }

        private void btnConvertKelvin_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtKelvin.Text, out double kelvinNumero))
            {
                Kelvin kelvin = new Kelvin(kelvinNumero);
                txtKelvinAKelvin.Text = kelvin.ToString();
                txtKelvinAFahrenheit.Text = ((Fahrenheit)kelvin).ToString();
                txtKelvinACelsius.Text = ((Celsius)kelvin).ToString();
            }
            else
            {
                txtKelvinAFahrenheit.Text = "";
                txtKelvinACelsius.Text = "";
                txtKelvinAKelvin.Text = "";
            }

        }
    }
}
