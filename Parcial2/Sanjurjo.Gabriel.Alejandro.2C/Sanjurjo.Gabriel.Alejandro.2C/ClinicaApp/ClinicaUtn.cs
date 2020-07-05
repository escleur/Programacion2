using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaLogic.Entidades;
using ClinicaLogic.Interfaces;
using System.Threading;

namespace ClinicaApp
{
    public partial class ClinicaUtn : Form
    {
        Thread atenderConsultaThread;
        Clinica clinica;
        IPaciente pacienteSeleccionado;
        IEspecialista especialistaSeleccionado;

        /// <summary>
        /// Constructor, abre las dos ventanas, carga la clinica y ejecuta el hilo
        /// y carga los grid view
        /// </summary>
        public ClinicaUtn()
        {
            InitializeComponent();

            pacienteSeleccionado = null;
            especialistaSeleccionado = null;
            try
            {
                clinica = new Clinica();
            }
            catch (Exception e)
            {
                ExcepcionesForm ef = new ExcepcionesForm(e);
                ef.ShowDialog();
            }

            ProximoTurno pt = new ProximoTurno(clinica);
            pt.Show();

            TurnoActual ta = new TurnoActual(clinica);
            ta.Show();

            if(clinica != null)
            {
                foreach (IPaciente item in clinica.Pacientes)
                {
                    int n = dgvPacientes.Rows.Add();
                    switch (item.NroClinica)
                    {
                        case 1:
                            dgvPacientes.Rows[n].Cells[0].Value = ((PacienteDB)item).Id;
                            dgvPacientes.Rows[n].Cells[1].Value = ((PacienteDB)item).NroClinica;
                            dgvPacientes.Rows[n].Cells[2].Value = ((PacienteDB)item).Apellido;
                            dgvPacientes.Rows[n].Cells[3].Value = ((PacienteDB)item).Nombre;
                            dgvPacientes.Rows[n].Cells[4].Value = ((PacienteDB)item).Edad;
                            dgvPacientes.Rows[n].Cells[5].Value = ((PacienteDB)item).Sexo;
                            dgvPacientes.Rows[n].Cells[6].Value = ((PacienteDB)item).Direccion;
                            dgvPacientes.Rows[n].Cells[7].Value = ((PacienteDB)item).ObraSocial;
                            break;
                        case 2:
                            dgvPacientes.Rows[n].Cells[0].Value = ((Paciente)item).Id;
                            dgvPacientes.Rows[n].Cells[1].Value = ((Paciente)item).NroClinica;
                            dgvPacientes.Rows[n].Cells[2].Value = ((Paciente)item).Apellido;
                            dgvPacientes.Rows[n].Cells[3].Value = ((Paciente)item).Nombre;
                            dgvPacientes.Rows[n].Cells[4].Value = ((Paciente)item).Edad;
                            dgvPacientes.Rows[n].Cells[5].Value = ((Paciente)item).Sexo;
                            dgvPacientes.Rows[n].Cells[6].Value = ((Paciente)item).Direccion;
                            dgvPacientes.Rows[n].Cells[7].Value = ((Paciente)item).ObraSocial;
                            break;
                    }
                }
                foreach (IEspecialista item in clinica.Especialistas)
                {
                    int n = dgvEspecialistas.Rows.Add();
                    switch (item.NroClinica)
                    {
                        case 1:
                            dgvEspecialistas.Rows[n].Cells[0].Value = ((EspecialistaDB)item).Id;
                            dgvEspecialistas.Rows[n].Cells[1].Value = ((EspecialistaDB)item).NroClinica;
                            dgvEspecialistas.Rows[n].Cells[2].Value = ((EspecialistaDB)item).Apellido;
                            dgvEspecialistas.Rows[n].Cells[3].Value = ((EspecialistaDB)item).Nombre;
                            dgvEspecialistas.Rows[n].Cells[4].Value = ((EspecialistaDB)item).Edad;
                            dgvEspecialistas.Rows[n].Cells[5].Value = ((EspecialistaDB)item).Sexo;
                            dgvEspecialistas.Rows[n].Cells[6].Value = ((EspecialistaDB)item).Direccion;
                            dgvEspecialistas.Rows[n].Cells[7].Value = ((EspecialistaDB)item).Especialidad;
                            break;
                        case 2:
                            dgvEspecialistas.Rows[n].Cells[0].Value = ((Especialista)item).Id;
                            dgvEspecialistas.Rows[n].Cells[1].Value = ((Especialista)item).NroClinica;
                            dgvEspecialistas.Rows[n].Cells[2].Value = ((Especialista)item).Apellido;
                            dgvEspecialistas.Rows[n].Cells[3].Value = ((Especialista)item).Nombre;
                            dgvEspecialistas.Rows[n].Cells[4].Value = ((Especialista)item).Edad;
                            dgvEspecialistas.Rows[n].Cells[5].Value = ((Especialista)item).Sexo;
                            dgvEspecialistas.Rows[n].Cells[6].Value = ((Especialista)item).Direccion;
                            dgvEspecialistas.Rows[n].Cells[7].Value = ((Especialista)item).Campo;
                            break;
                    }
                }

            }

            atenderConsultaThread = new Thread(AtenderConsulta);

            atenderConsultaThread.Start();
        }

        /// <summary>
        /// Se llama desde el segundo hilo para ejecutar el siguiente turno
        /// </summary>
        void AtenderConsulta()
        {
            do
            {

                Thread.Sleep(10000);
                this.clinica.SiguienteTurno();

            } while (true);
        }

        /// <summary>
        /// Cuando entra en la fila carga el especialista como seleccionado y lo muestra en el label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEspecialistas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            StringBuilder sb = new StringBuilder();


            if (n != -1)
            {
                int id = (int)dgvEspecialistas.Rows[n].Cells[0].Value;
                especialistaSeleccionado = clinica.GetEspecialistaById(id);
                string apellido = (string)dgvEspecialistas.Rows[n].Cells[2].Value;
                string nombre = (string)dgvEspecialistas.Rows[n].Cells[3].Value;

                sb.AppendFormat("Especialista: {0}, {1}", apellido, nombre);

                txtEspecialista.Text = sb.ToString();
            }
        }

        /// <summary>
        /// Cuando entra en la fila carga el paciente como seleccionado y lo muestra en el label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPacientes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            StringBuilder sb = new StringBuilder();


            if (n != -1)
            {
                int id = (int)dgvPacientes.Rows[n].Cells[0].Value;
                pacienteSeleccionado = clinica.GetPacienteById(id);
                string apellido = (string)dgvPacientes.Rows[n].Cells[2].Value;
                string nombre = (string)dgvPacientes.Rows[n].Cells[3].Value;

                sb.AppendFormat("Paciente: {0}, {1}", apellido, nombre);

                txtPaciente.Text = sb.ToString();
            }
        }

        /// <summary>
        /// Crea el turno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrearTurno_Click(object sender, EventArgs e)
        {
            try
            {
                clinica.AgregarTurno(pacienteSeleccionado, especialistaSeleccionado);
                MessageBox.Show("Turno Generado.");

            }
            catch (Exception ex)
            {
                ExcepcionesForm ef = new ExcepcionesForm(ex);
                ef.ShowDialog();

            }
        }

        /// <summary>
        /// Al cerrar la ventana aborta el turno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClinicaUtn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.atenderConsultaThread.IsAlive)
            {
                this.atenderConsultaThread.Abort();
            }
        }
    }
}
