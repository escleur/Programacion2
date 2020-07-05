using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaLogic.Interfaces;
using ClinicaLogic.Comun;

namespace ClinicaLogic.Entidades
{
    public class Especialista : Persona, IEspecialista
    {
        private Comun.Enumerado.Especialidad campo;
        private int nroClinica;

        /// <summary>
        /// Constructor especialista para xml
        /// </summary>
        public Especialista() : this(0, "", "", 0, "", "", Comun.Enumerado.Especialidad.ClinicaGeneral)
        {

        }

        /// <summary>
        /// Constructor especialista para xml
        /// </summary>
        /// <param name="id"></param>
        /// <param name="apellido"></param>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="sexo"></param>
        /// <param name="direccion"></param>
        /// <param name="campo"></param>
        public Especialista(int id, string apellido, string nombre, int edad, string sexo, string direccion, Comun.Enumerado.Especialidad campo)
            : base(id, apellido, nombre, edad, sexo, direccion)
        {
            this.Campo = campo;
            this.nroClinica = 2;
        }

        /// <summary>
        /// Propiedad campo
        /// </summary>
        public Comun.Enumerado.Especialidad Campo
        {
            get
            {
                return this.campo;
            }
            set
            {
                this.campo = value;
            }
        }

        /// <summary>
        /// retorna 2 porque es la de xml, espacialistaBD retorna 1
        /// </summary>
        public int NroClinica
        {
            get
            {
                return this.nroClinica;
            }
        }

        /// <summary>
        /// Igual si es un objeto de la misma tipo
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Especialista;
        }

    }
}
