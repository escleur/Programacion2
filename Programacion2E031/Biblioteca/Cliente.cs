using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        #region MyRegion
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public int Numero
        {
            get
            {
                return this.numero;
            }
        } 
        #endregion

        #region Constructores
        public Cliente(int numero):this(numero, "")
        {

        }
        public Cliente(int numero, string nombre)
        {
            this.numero = numero;
            this.nombre = nombre;
        }
        #endregion

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.numero == c2.numero;
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
        public override string ToString()
        {
            return $"Nombre: {this.nombre}    Numero: {this.numero}\n";
        }
    }
}
