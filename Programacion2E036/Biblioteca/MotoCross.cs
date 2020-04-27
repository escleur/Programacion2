﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class MotoCross : VehiculoDeCarrera
    {

        private short cilindrada;

        public short Cilindrada
        {
            get
            {
                return this.cilindrada;
            }
            set
            {
                this.cilindrada = value;
            }
        }

        #region Constructores
        public MotoCross(short numero, string escuderia) : base(numero, escuderia)
        {

        }
        public MotoCross(short numero, string escuderia, short cilindrada) : this(numero, escuderia)
        {
            this.Cilindrada = cilindrada;
        }


        #endregion

        #region Sobrecarga de operadores
        public static bool operator ==(MotoCross a1, MotoCross a2)
        {
            return (VehiculoDeCarrera)a1 == (VehiculoDeCarrera)a2
                && a1.Cilindrada == a2.Cilindrada;
        }
        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return !(a1 == a2);
        }
        #endregion


        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Cilindrada: {this.Cilindrada}");
            return sb.ToString();

        }
    }