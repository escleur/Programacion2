using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmBar
{
    public partial class FrmCantidadEspaciosCantina : Form
    {
        public FrmCantidadEspaciosCantina()
        {
            InitializeComponent();
        }


        public short CantidadEspacios
        {
            get
            {
                return (short)this.nudCantidad.Value;
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
