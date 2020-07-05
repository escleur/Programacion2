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

namespace FrmBar
{
    public partial class FrmCantina : Form
    { 
        public FrmCantina()
        {
            InitializeComponent();
          
        }

        public FrmCantina(short cantidad) : this()
        {
            this.barra.SetCantina = new Cantina(cantidad);

        }
        public Cantina GetCantina()
        {
            return this.barra.GetCantina;
        }

        public String GetInforme
        {
            get
            {
                return this.barra.GetCantina.GetInforme();
            }
        }

        private void FrmCantina_Load(object sender, EventArgs e)
        {
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

        private void FrmCantina_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }
    }
}
