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
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    StreamReader reader = null;
                    try
                    {
                        reader = new StreamReader(filePath);
                        richTextBox.Text = reader.ReadToEnd();
                        ultimoArchivoAbierto = filePath;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                    finally
                    {
                        if (!(reader is null))
                        {
                            reader.Close();

                        }
                    }
                }
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;

                StreamWriter writer = null;
                try
                {
                    writer = new StreamWriter(filePath);

                    foreach (char item in richTextBox.Text)
                    {
                        writer.Write(item);
                    }
                    ultimoArchivoAbierto = filePath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    if (!(writer is null))
                    {
                        writer.Close();

                    }
                }

            }

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ultimoArchivoAbierto == null)
            {
                guardarComoToolStripMenuItem_Click(sender, e);
            }
            else
            {
                string filePath = ultimoArchivoAbierto;
                StreamWriter writer = null;
                try
                {
                    writer = new StreamWriter(filePath);

                    foreach (char item in richTextBox.Text)
                    {
                        writer.Write(item);
                    }
                    ultimoArchivoAbierto = filePath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    if (!(writer is null))
                    {
                        writer.Close();

                    }
                }
            }

        }
    }
}
