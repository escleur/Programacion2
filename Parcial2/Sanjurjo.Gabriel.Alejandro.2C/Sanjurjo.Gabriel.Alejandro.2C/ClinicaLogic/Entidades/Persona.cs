using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ClinicaLogic.Entidades
{
    public abstract class Persona
    {
        protected int id;
        protected string apellido;
        protected string nombre;
        protected int edad;
        protected string sexo;
        protected string direccion;

        /// <summary>
        /// Constructor persona
        /// </summary>
        public Persona() : this(0,"","",0,"","")
        {
                
        }

        /// <summary>
        /// Constructor persona
        /// </summary>
        /// <param name="id"></param>
        /// <param name="apellido"></param>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="sexo"></param>
        /// <param name="direccion"></param>
        public Persona(int id, string apellido, string nombre, int edad, string sexo, string direccion)
        {
            this.Id = id;
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Edad = edad;
            this.Sexo = sexo;
            this.Direccion = direccion;
        }

        /// <summary>
        /// Propiedad id
        /// </summary>
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        /// <summary>
        /// Propiedad Apellido
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = ValidarNombreApellido(value);
            }
        }

        /// <summary>
        /// Propiedad Nombre
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = ValidarNombreApellido(value);
            }
        }

        /// <summary>
        /// Propiedad Edad
        /// </summary>
        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                if(value > 0)
                {
                    this.edad = value;
                }
                else
                {
                    this.edad = 0;
                }
            }
        }


        /// <summary>
        /// Propiedad Sexo
        /// </summary>
        public string Sexo
        {
            get
            {
                return this.sexo;
            }
            set
            {
                this.sexo = value;
            }
        }

        /// <summary>
        /// Propiedad Direccion
        /// </summary>
        public string Direccion
        {
            get
            {
                return this.direccion;
            }
            set
            {
                this.direccion = value;
            }
        }


        /// <summary>
        /// Valida nombre y apellido
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        private string ValidarNombreApellido(string dato)
        {
            string retorno = string.Empty;
            string pattern = @"\b[a-zA-Z .ñá-úÑÁ-Ú]+";
            Regex re = new Regex(pattern);
            if (re.Match(dato).Value == dato)
            {
                retorno = dato;
            }
            return retorno;
        }

        /// <summary>
        /// Son iguales si son el mismo tipo y tienen mismo id
        /// </summary>
        /// <param name="persona1"></param>
        /// <param name="persona2"></param>
        /// <returns></returns>
        public static bool operator ==(Persona persona1, Persona persona2)
        {
            return (persona1.Equals(persona2) && persona1.Id == persona2.Id);
        }

        /// <summary>
        /// !=
        /// </summary>
        /// <param name="persona1"></param>
        /// <param name="persona2"></param>
        /// <returns></returns>
        public static bool operator !=(Persona persona1, Persona persona2)
        {
            return !(persona1 == persona2);
        }

    }
}
