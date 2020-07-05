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
using ClinicaLogic.Comun;

namespace ClinicaApp
{
    public partial class TurnoActual : Form
    {
        Clinica clinica;

        /// <summary>
        /// Constructor, Carga el evento
        /// </summary>
        /// <param name="clinica"></param>
        public TurnoActual(Clinica clinica)
        {
            InitializeComponent();
            this.clinica = clinica;
            this.clinica.EventoTurno += this.MostrarTurnoActual;

        }

        /// <summary>
        /// Actualiza la pantalla y registra el turno saliente desde el hilo correcto
        /// </summary>
        delegate void Callback();
        public void MostrarTurnoActual()
        {

            if (this.txtHistorialTurnos.InvokeRequired)
            {
                Callback d = new Callback(this.MostrarTurnoActual);
                this.Invoke(d);
            }
            else
            {
                this.ActualizarPacienteActual();
                this.RegistraTurnoSaliente();
            }
        }

        /// <summary>
        /// Actualiza pantalla
        /// </summary>
        private void ActualizarPacienteActual()
        {
            if (this.clinica.TurnoActual != null)
            {
                this.clinica.TurnoActual.generarFechaDelTurno();

                if (this.clinica.TurnoActual.Paciente.NroClinica == 1)
                {
                    PacienteDB paciente = (PacienteDB)this.clinica.TurnoActual.Paciente;
                    EspecialistaDB especialista = (EspecialistaDB)this.clinica.TurnoActual.Especialista;
                    this.lblEspecialidad.Text = especialista.Especialidad.ToString();
                    this.lblPaciente.Text = paciente.Apellido.ApellidoYNombre(paciente.Nombre);
                }
                else
                {
                    Paciente paciente = (Paciente)this.clinica.TurnoActual.Paciente;
                    Especialista especialista = (Especialista)this.clinica.TurnoActual.Especialista;
                    this.lblEspecialidad.Text = especialista.Campo.ToString();
                    this.lblPaciente.Text = paciente.Apellido.ApellidoYNombre(paciente.Nombre);
                }
            }
            else
            {
                this.lblEspecialidad.Text = "";
                this.lblPaciente.Text = "";
            }

        }

        /// <summary>
        /// Guarda turno saliente y lo registra en el historial
        /// </summary>
        void RegistraTurnoSaliente()
        {
            if (this.clinica.TurnoArchivo != null)
            {
                this.clinica.TurnoArchivo.generarObservacionDelTurno();

                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("{0}   ", this.clinica.TurnoArchivo.FechaTurno.ToString("dd/MM/yyyy HH:mm:ss"));
                sb.AppendFormat("Clinica: {0}    -    ", this.clinica.TurnoArchivo.Paciente.NroClinica);
                sb.AppendFormat("Paciente: {0}    -    ", ((Persona)this.clinica.TurnoArchivo.Paciente).Apellido.ApellidoYNombre(((Persona)this.clinica.TurnoArchivo.Paciente).Nombre));
                sb.AppendFormat("Especialista: {0} \n", ((Persona)this.clinica.TurnoArchivo.Especialista).Apellido.ApellidoYNombre(((Persona)this.clinica.TurnoArchivo.Especialista).Nombre));
                this.txtHistorialTurnos.Text = sb.ToString() + this.txtHistorialTurnos.Text;

                if (this.clinica.TurnoArchivo.Paciente.NroClinica == 1)
                {
                    DataBase.GuardarTurno(this.clinica.TurnoArchivo);
                }
                else
                {
                    XmlBinario.GuardarTurno(this.clinica.TurnoArchivo);
                }
                
            }


        }
    }
}
