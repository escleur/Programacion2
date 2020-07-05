using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaLogic.Interfaces;
using ClinicaLogic.Comun;

namespace ClinicaLogic.Entidades
{
    public sealed class Clinica
    {
        Queue<Turno<IPaciente,IEspecialista>> turnos;

        Turno<IPaciente, IEspecialista> turnoProximo;
        Turno<IPaciente, IEspecialista> turnoActual;
        Turno<IPaciente, IEspecialista> turnoArchivo;

        List<IPaciente> pacientes;
        List<IEspecialista> especialistas;

        /// <summary>
        /// Indexador por id solo lectura
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public IPaciente this[int index]
        {
            get
            {
                foreach (IPaciente item in pacientes)
                {
                    if(item.Id == index)
                    {
                        return item;
                    }
                }
                return null;
            }
        }

        /// <summary>
        /// Constructor, instancia las listas y carga desde xml y db
        /// </summary>
        public Clinica()
        {
            turnos = new Queue<Turno<IPaciente, IEspecialista>>();
            pacientes = new List<IPaciente>();
            especialistas = new List<IEspecialista>();

            DataBase.LeerPacientes(ref pacientes);
            DataBase.LeerEspecialistas(ref especialistas);
            XmlBinario.LeerPacientes(ref pacientes);
            XmlBinario.LeerEspecialistas(ref especialistas);
        }

        /// <summary>
        /// Propiedad, guarda el turno que ya paso y hay que archivar
        /// </summary>
        public Turno<IPaciente, IEspecialista> TurnoArchivo
        {
            get
            {
                return this.turnoArchivo;
            }

        }

        /// <summary>
        /// Propiedad, turno actual
        /// </summary>
        public Turno<IPaciente, IEspecialista> TurnoActual
        {
            get
            {
                return this.turnoActual;
            }

        }

        /// <summary>
        /// Propiedad, turno proximo
        /// </summary>
        public Turno<IPaciente, IEspecialista> TurnoProximo
        {
            get
            {
                return this.turnoProximo;
            }

        }

        /// <summary>
        /// Lista de pacientes
        /// </summary>
        public List<IPaciente> Pacientes
        {
            get
            {
                return this.pacientes;
            }
            set
            {
                this.pacientes = value;
            }
        }

        /// <summary>
        /// Lista de especialistas
        /// </summary>
        public List<IEspecialista> Especialistas
        {
            get
            {
                return this.especialistas;
            }
            set
            {
                this.especialistas = value;
            }
        }

        /// <summary>
        /// Busca un paciente por su id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IPaciente GetPacienteById(int id)
        {
            IPaciente paciente = null;
            for (int i = 0; i < this.pacientes.Count(); i++)
            {
                if (!(this.pacientes is null) && this.pacientes[i].Id == id)
                {
                    paciente = this.pacientes[i];
                    break;
                }
            }
            return paciente;
        }

        /// <summary>
        /// Busca un especialista por su id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEspecialista GetEspecialistaById(int id)
        {
            IEspecialista especialista = null;
            for (int i = 0; i < this.especialistas.Count(); i++)
            {
                if (!(this.especialistas is null) && this.especialistas[i].Id == id)
                {
                    especialista = this.especialistas[i];
                    break;
                }
            }
            return especialista;
        }

        /// <summary>
        /// Alta de turno
        /// </summary>
        /// <param name="paciente"></param>
        /// <param name="especialista"></param>
        public void AgregarTurno(IPaciente paciente, IEspecialista especialista)
        {
            Turno<IPaciente, IEspecialista> turno = new Turno<IPaciente, IEspecialista>(paciente, especialista);
            turnos.Enqueue(turno);
        }

        public delegate void DelegadoTurno();
        public event DelegadoTurno EventoTurno;

        /// <summary>
        /// Avanza el turno pasando por la cola a el turno actual a el turno archivo
        /// y lanza el evento para actualizar las ventanas, es llamado desde el segundo hilo
        /// </summary>
        public void SiguienteTurno()
        {
            this.turnoArchivo = this.turnoActual;
            this.turnoActual = this.turnoProximo;
            if(this.turnos.Count > 0)
            {
                this.turnoProximo = this.turnos.Dequeue();

            }
            else
            {
                this.turnoProximo = null;
            }
            this.EventoTurno(); //lanza el evento
        }
    }
}
