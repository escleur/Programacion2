using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Animal
    {
        int kilosAlimento;
        string nombre;


        public abstract bool ComeBalanceado
        {
            get;
        }


        public abstract bool ComePasto
        {
            get;
        }


        public int KilosAlimento
        {
            get
            {
                return this.kilosAlimento;
            }
        }

        public Animal(string nombre, int kilosAlimento)
        {
            this.nombre = nombre;
            this.kilosAlimento = kilosAlimento;
        }
        public virtual string Datos()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("{0} come {1}kg", this.nombre, this.kilosAlimento));
            sb.AppendLine(string.Format("Consume balanceado {0}", (this.ComeBalanceado)?"SI":"NO"));
            sb.AppendLine(string.Format("Consume pasto {0}", (this.ComePasto)?"SI":"NO"));
            return sb.ToString();


        }


    }
}
