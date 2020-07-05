using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaLogic.Interfaces;
using ClinicaLogic.Comun;

namespace ClinicaLogic.Entidades
{
    public class Turno <P, E> where P : class, IPaciente where E : class, IEspecialista   
    {
        private P paciente;
        private E especialista;
        private DateTime fechaTurno;
        private string observacionesTurno;

        /// <summary>
        /// Constructor turno
        /// </summary>
        public Turno()
        {
            
        }

        /// <summary>
        /// Constructor turno
        /// </summary>
        /// <param name="paciente"></param>
        /// <param name="especialista"></param>
        public Turno(P paciente, E especialista)
        {
            if(!(paciente is null) && !(especialista is null))
            {
                if(paciente.NroClinica == especialista.NroClinica)
                {
                    this.paciente = paciente;
                    this.especialista = especialista;
                }
                else
                {
                    throw new ClinicaNoCoincideException("El paciente y el especialista deben ser de la misma clinica");
                }
            }
        }

        /// <summary>
        /// Propiedad paciente
        /// </summary>
        public P Paciente
        {
            get
            {
                return this.paciente;
            }
            set
            {
                this.paciente = value;
            }
        }

        /// <summary>
        /// Propiedad Especialista
        /// </summary>
        public E Especialista
        {
            get
            {
                return this.especialista;
            }
            set
            {
                this.especialista = value;
            }
        }

        /// <summary>
        /// Propiedad Observaciones Turno
        /// </summary>
        public string ObservacionesTurno
        {
            get
            {
                return this.observacionesTurno;
            }
            set
            {
                this.observacionesTurno = value;
            }
        }

        /// <summary>
        /// Propiedad FechaTurno
        /// </summary>
        public DateTime FechaTurno
        {
            get
            {
                return this.fechaTurno;
            }
            set
            {
                this.fechaTurno = value;
            }
        }

        /// <summary>
        /// Genera una observacion al azar
        /// </summary>
        public void generarObservacionDelTurno()
        {
            string retorno = "";

            string [] observaciones = { "Sin observacion.",
                                        "Esta con fiebre",
                                        "Tiene angina",
                                        "Esta con dolor de espalda",
                                        "Le duele el pie",
                                        "Tiene varicela",
                                        "Con retraso"};
            Random r = new Random();
            int posicion = r.Next(0, observaciones.Count());

            retorno = observaciones[posicion];

            this.observacionesTurno = retorno;
        }

        /// <summary>
        /// Genera la fecha
        /// </summary>
        public void generarFechaDelTurno()
        {
            this.fechaTurno = DateTime.Now;
        }

    }
}
