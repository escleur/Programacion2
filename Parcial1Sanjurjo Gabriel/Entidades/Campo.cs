using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Campo
    {

        public enum Tipo
        {
            Pastoreo, Engorde
        }

        int alimentoDisponible;
        List<Animal> animales;
        static Tipo servicio;


        public static Tipo TipoServicio
        {
            set
            {
                Campo.servicio = value;
            }
        }


        private Campo()
        {
            animales = new List<Animal>();
        }
        public Campo(int alimento):this()
        {
            this.alimentoDisponible = alimento;
        }
        static Campo()
        {
            servicio = Campo.Tipo.Engorde;
        }

        public static bool operator +(Campo campo, Animal animal)
        {
            bool retorno = false;
            if(campo.alimentoDisponible >= campo.AlimentoComprometido(animal))
            {
                campo.animales.Add(animal);
                retorno = true;
            }
            return retorno;
        }

        private int AlimentoComprometido()
        {
            int suma = 0;
            foreach (Animal item in animales)
            {
                suma += item.KilosAlimento;
                    
            }
            return suma;
        }

        private int AlimentoComprometido(Animal animal)
        {
            return this.AlimentoComprometido() + animal.KilosAlimento;
        }

        public override string ToString()
        {


            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Servicio del campo: {Campo.servicio}");
            sb.AppendLine($"Alimento Comprometido {this.AlimentoComprometido()} de {this.alimentoDisponible}");

            foreach (Animal item in this.animales)
            {
                sb.AppendLine(item.Datos());

            }

            return sb.ToString();

        }

    }
}
