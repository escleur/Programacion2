using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContadorDePalabras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static bool esLetra(char letra)
        {
            bool retorno = false;
            if((letra >= 'a' && letra <= 'z')||(letra >= 'A' && letra <= 'Z'))
            {
                retorno = true;
            }
            return retorno;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string palabras = texto.Text;
            Dictionary<string, int> diccionario = new Dictionary<string, int>();
            string palabra = string.Empty;
            bool buscarNuevaPalabra = true;
            bool buscandoLetras = false;

            foreach (char caracter in palabras)
            {
                if(buscarNuevaPalabra)
                {
                    if (esLetra(caracter))
                    {
                        palabra += caracter;
                        buscarNuevaPalabra = false;
                    }
                }
                else
                {
                    if (esLetra(caracter))
                    {
                        palabra += caracter;
                    }
                    else
                    {
                        //palabra terminada
                        buscarNuevaPalabra = true;
                        if (diccionario.ContainsKey(palabra))
                        {
                            diccionario[palabra]++;
                        }
                        else
                        {
                            diccionario.Add(palabra, 1);
                        }
                        palabra = "";
                    }
                }
            }
            if(palabra != "")
            {
                if (diccionario.ContainsKey(palabra))
                {
                    diccionario[palabra]++;
                }
                else
                {
                    diccionario.Add(palabra, 1);
                }

            }

            StringBuilder sb = new StringBuilder();
            int contador = 0;
            foreach (KeyValuePair<string,int> item in diccionario.OrderByDescending(x => x.Value))
            {
                if(contador < 3)
                    sb.AppendLine(item.Key + "   " + item.Value);
                contador++;
            }
            MessageBox.Show(sb.ToString());

        }
    }
}
