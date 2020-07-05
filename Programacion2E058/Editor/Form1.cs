using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using IO;


namespace Editor
{
    public partial class Form1 : Form
    {
        string ultimoArchivoAbierto;
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = $"{richTextBox.Text.Count()} Caracteres";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileContent = string.Empty;
            string filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt|dat files (*.dat)|*.dat";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    try
                    {
                        if (Path.GetExtension(filePath) == ".txt")
                        {
                            PuntoTxt ptxt = new PuntoTxt();
                            richTextBox.Text = ptxt.Leer(filePath);
                        }
                        else
                        {
                            PuntoDat pdat = new PuntoDat();
                            pdat = pdat.Leer(filePath);
                            richTextBox.Text = pdat.Contenido;

                        }
                        ultimoArchivoAbierto = filePath;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|dat files (*.dat)|*.dat";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
                try
                {
                    if (Path.GetExtension(filePath) == ".txt")
                    {
                        PuntoTxt ptxt = new PuntoTxt();
                        ptxt.GuardarComo(filePath, richTextBox.Text);
                    }
                    else
                    {
                        PuntoDat pdat = new PuntoDat();
                        pdat.Contenido = richTextBox.Text;
                        pdat.GuardarComo(filePath, pdat);

                    }
                    ultimoArchivoAbierto = filePath;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = ultimoArchivoAbierto;
            try
            {
                if (Path.GetExtension(filePath) == ".txt")
                {
                    PuntoTxt ptxt = new PuntoTxt();
                    ptxt.Guardar(filePath, richTextBox.Text);
                }
                else
                {
                    PuntoDat pdat = new PuntoDat();
                    pdat.Contenido = richTextBox.Text;
                    pdat.Guardar(filePath, pdat);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
