using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Competencia<T> where T : VehiculoDeCarrera
    {
        public enum TipoCompetencia{F1, MotoCross }
        private static Random random = new Random();
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<T> competidores;
        private TipoCompetencia tipo;

        private Competencia()
        {
            this.competidores = new List<T>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
            this.tipo = tipo;
        }

        public List<T> Competidores
        {
            get
            {
                return this.competidores;
            }
        }

        public short CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                this.cantidadCompetidores = value;
            }
        }
        public short CantidadVueltas
        {
            get
            {
                return this.cantidadVueltas;
            }
            set
            {
                this.cantidadVueltas = value;
            }
        }
        public static bool operator +(Competencia<T> c, VehiculoDeCarrera a)
        {
            bool seAgrego = false;
            if (c.competidores.Count() < c.cantidadCompetidores)
            {
                try
                {

                    if (c != a)//lo agrego
                    {
                        //if (c.tipo == TipoCompetencia.F1 && a is AutoF1)
                        //{
                            a.EnCompetencia = true;
                            a.VueltasRestantes = c.cantidadVueltas;
                            a.CantidadCombustible = ((short)random.Next(15, 100));
                            c.competidores.Add((T)a);
                            seAgrego = true;
                        //}
                        /*if (c.tipo == TipoCompetencia.MotoCross && a is MotoCross)
                        {
                            a.EnCompetencia = true;
                            a.VueltasRestantes = c.cantidadVueltas;
                            a.CantidadCombustible = ((short)random.Next(15, 100));
                            c.competidores.Add(a);
                            seAgrego = true;
                        }*/
                    }
                }
                catch (CompetenciaNoDisponibleException e)
                {

                    throw new CompetenciaNoDisponibleException("Competencia incorrecta", "Competencia", "Operador +", e);
                }
            }

            return seAgrego;
        }
        public static bool operator -(Competencia<T> c, VehiculoDeCarrera a)
        {
            bool seQuito = false;
            if (c == a)//lo quito
            {
                for(int i = 0; i < c.competidores.Count(); i++)
                {
                    if (c.competidores[i] == a)
                    {
                        c.competidores.RemoveAt(i);
                    }
                }                
                a.EnCompetencia = false;
                a.VueltasRestantes = 0;
                seQuito = true;
            }

            return seQuito;
        }



        public static bool operator ==(Competencia<T> c, VehiculoDeCarrera a)
        {
            bool estabaElAuto = false;
            if ((c.tipo == TipoCompetencia.F1 && a is MotoCross) || (c.tipo == TipoCompetencia.MotoCross && a is AutoF1))
            {
                throw new CompetenciaNoDisponibleException("El vehiculo no corresponde a la competencia", "Competencia", "Operador ==");
            }
            foreach (VehiculoDeCarrera item in c.competidores)
            {
                if (item == a)
                {
                    estabaElAuto = true;
                    break;
                }
            }
            return estabaElAuto;
        }
        public static bool operator !=(Competencia<T> c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Competencia ");
            sb.AppendLine($"Cantidad de vueltas: {this.cantidadVueltas}");
            sb.AppendLine($"Cantidad de competidores: {this.cantidadCompetidores}");
            foreach (VehiculoDeCarrera v in this.competidores)
            {
                sb.AppendLine("Vehiculo:");
                sb.AppendLine(v.MostrarDatos());
            }
            return sb.ToString();

        }

    }
}
