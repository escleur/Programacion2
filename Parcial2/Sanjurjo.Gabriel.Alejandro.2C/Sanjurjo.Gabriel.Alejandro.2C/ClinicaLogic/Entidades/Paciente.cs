using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaLogic.Interfaces;
using ClinicaLogic.Comun;

namespace ClinicaLogic.Entidades
{
    public class Paciente : Persona, IPaciente
    {
        private Comun.Enumerado.ObraSocial obraSocial;
        private int nroClinica;

        /// <summary>
        /// Constructor paciente para xml
        /// </summary>
        public Paciente() : this(0, "", "", 0, "", "", Comun.Enumerado.ObraSocial.NoTiene)
        {

        }

        /// <summary>
        /// Constructor paciente para xml
        /// </summary>
        /// <param name="id"></param>
        /// <param name="apellido"></param>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="sexo"></param>
        /// <param name="direccion"></param>
        /// <param name="obraSocial"></param>
        public Paciente(int id, string apellido, string nombre, int edad, string sexo, string direccion, Comun.Enumerado.ObraSocial obraSocial)
            : base(id, apellido, nombre, edad, sexo, direccion)
        {
            this.ObraSocial = obraSocial;
            this.nroClinica = 2;
        }

        /// <summary>
        /// Propiedad
        /// </summary>
        public Comun.Enumerado.ObraSocial ObraSocial
        {
            get
            {
                return this.obraSocial;
            }
            set
            {
                this.obraSocial = value;
            }
        }

        /// <summary>
        /// Vale 2 por ser xml
        /// </summary>
        public int NroClinica
        {
            get
            {
                return this.nroClinica;
            }
        }

        /// <summary>
        /// Iguales si es el mismo tipo
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Paciente;
        }

    }
}
