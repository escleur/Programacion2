using System;
using System.Text;
using System.Windows.Forms;

namespace ClinicaApp
{
    public partial class ExcepcionesForm : Form
    {
        private Exception exception;

        /// <summary>
        /// Constructor, desactiva el boton si no hay detalle
        /// </summary>
        /// <param name="exception"></param>
        public ExcepcionesForm(Exception exception)
        {
            InitializeComponent();
            this.exception = exception;
            if (this.exception.InnerException == null)
            {
                this.btnDetalles.Enabled = false;
            }
        }

        /// <summary>
        /// Muestra el detalle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDetalles_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            Exception innerException = this.exception.InnerException;
            while (innerException != null)
            {
                sb.AppendLine(innerException.Message);
                innerException = innerException.InnerException;
            }

            MessageBox.Show(sb.ToString(), "Detalle de Error", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Cierra la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Muestra el mensaje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExcepcionesForm_Load_1(object sender, EventArgs e)
        {
            this.lblMessage.Text = exception.Message;

        }
    }
}
