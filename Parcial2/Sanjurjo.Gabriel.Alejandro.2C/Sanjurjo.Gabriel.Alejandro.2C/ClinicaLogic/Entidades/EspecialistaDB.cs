using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaLogic.Interfaces;

namespace ClinicaLogic.Entidades
{
    public class EspecialistaDB : Persona, IEspecialista
    {
        private Comun.Enumerado.Especialidad especialidad;
        private int nroClinica;

        /// <summary>
        /// Constructor especialista para db
        /// </summary>
        public EspecialistaDB() : this(0, "", "", 0, "", "", Comun.Enumerado.Especialidad.ClinicaGeneral)
        {

        }

        /// <summary>
        /// Constructor especialista para db
        /// </summary>
        /// <param name="id"></param>
        /// <param name="apellido"></param>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="sexo"></param>
        /// <param name="direccion"></param>
        /// <param name="especialidad"></param>
        public EspecialistaDB(int id, string apellido, string nombre, int edad, string sexo, string direccion, Comun.Enumerado.Especialidad especialidad)
            : base(id, apellido, nombre, edad, sexo, direccion)
        {
            this.Especialidad = especialidad;
            this.nroClinica = 1;
        }

        /// <summary>
        /// propiedad especialidad
        /// </summary>
        public Comun.Enumerado.Especialidad Especialidad
        {
            get
            {
                return this.especialidad;
            }
            set
            {
                this.especialidad = value;
            }
        }

        /// <summary>
        /// retorna 1 porque es db, xml retorna 2
        /// </summary>
        public int NroClinica
        {
            get
            {
                return this.nroClinica;
            }
        }

        /// <summary>
        /// Igual si es el mismo tipo
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is EspecialistaDB;
        }
    }
}
