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
    public partial class ProximoTurno : Form
    {
        Clinica clinica;

        /// <summary>
        /// Constructor, carga el evento
        /// </summary>
        /// <param name="clinica"></param>
        public ProximoTurno(Clinica clinica)
        {
            InitializeComponent();
            this.clinica = clinica;
            this.clinica.EventoTurno += this.MostrarProximoTurno;
        }

        /// <summary>
        /// Actualiza la pantalla en el hilo correcto
        /// </summary>
        delegate void Callback();
        public void MostrarProximoTurno()
        {
            if (this.lblPaciente.InvokeRequired)
            {
                Callback d = new Callback(this.MostrarProximoTurno);
                this.Invoke(d);
            }
            else
            {
                this.ActualizarPantalla();
            }
        }

        /// <summary>
        /// Hace la actualizacion de pantalla
        /// </summary>
        public void ActualizarPantalla()
        {
            if (this.clinica.TurnoProximo != null)
            {
                if (this.clinica.TurnoProximo.Paciente.NroClinica == 1)
                {
                    PacienteDB paciente = (PacienteDB)this.clinica.TurnoProximo.Paciente;
                    EspecialistaDB especialista = (EspecialistaDB)this.clinica.TurnoProximo.Especialista;
                    this.lblEspecialidad.Text = especialista.Especialidad.ToString();
                    this.lblPaciente.Text = paciente.Apellido.ApellidoYNombre(paciente.Nombre);
                }
                else
                {
                    Paciente paciente = (Paciente)this.clinica.TurnoProximo.Paciente;
                    Especialista especialista = (Especialista)this.clinica.TurnoProximo.Especialista;
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
    }
}
