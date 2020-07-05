using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaLogic.Entidades
{
    [Serializable]
    public class TurnoSerializador
    {
        private int paciente;
        private int especialista;
        private DateTime fechaTurno;
        private string observacionesTurno;

        /// <summary>
        /// Constructor
        /// </summary>
        public TurnoSerializador()
            : this(0,0,DateTime.Now,"")
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="paciente"></param>
        /// <param name="especialista"></param>
        /// <param name="fechaTurno"></param>
        /// <param name="observacionesTurno"></param>
        public TurnoSerializador(int paciente, int especialista, DateTime fechaTurno, string observacionesTurno)
        {
            this.paciente = paciente;
            this.especialista = especialista;
            this.fechaTurno = fechaTurno;
            this.observacionesTurno = observacionesTurno;
        }

        /// <summary>
        /// Propiedad Paciente
        /// </summary>
        public int Paciente
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
        public int Especialista
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
        /// Propiedad Fecha Turno
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

    }
}
