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
using ControlCantina;

namespace Vista
{
    public partial class FrmCantina : Form
    { 
        public FrmCantina()
        {
            InitializeComponent();
          
        }

        private void FrmCantina_Load(object sender, EventArgs e)
        {
            this.barra.SetCantina = Cantina.GetCantina(10);
            cmbBotellaTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Botella.Tipo tipo;
            Enum.TryParse<Botella.Tipo>(cmbBotellaTipo.SelectedValue.ToString(), out tipo);
            Botella botella = null;
            if (radioCerveza.Checked)
            {
                botella = new Cerveza((int)numericCapacidad.Value, txtMarca.Text, tipo, (int)numericContenido.Value);
            }
            if (radioAgua.Checked)
            {
                botella = new Agua((int)numericCapacidad.Value, txtMarca.Text, (int)numericContenido.Value);
            }
            this.barra.AgregarBotella(botella);
        }
    }
}
