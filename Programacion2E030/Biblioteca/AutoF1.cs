using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class AutoF1
    {
        #region Atributos
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;
        #endregion

        #region Constructores
        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        } 
        #endregion

        #region Sobrecarga de operadores
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return a1.numero == a2.numero && a1.escuderia == a2.escuderia;
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
        #endregion

        #region Getters and Setters
        public void SetCantidadCombustible(short cantidad)
        {
            this.cantidadCombustible = cantidad;
        }
        public short GetCantidadCombustible()
        {
            return this.cantidadCombustible;
        }

        public void SetEnCompetencia(bool enCompetencia)
        {
            this.enCompetencia = enCompetencia;
        }
        public bool GetEnCompetencia()
        {
            return this.enCompetencia;
        }


        public void SetVueltasRestantes(short vueltasRestantes)
        {
            this.vueltasRestantes = vueltasRestantes;
        }
        public short GetVueltasRestantes()
        {
            return this.vueltasRestantes;
        } 
        #endregion

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Escuderia: {this.escuderia}");
            sb.AppendLine($"Numero: {this.numero}");
            sb.AppendLine("Esta compitiendo: " +
                ((this.enCompetencia)?"Si":"No"));
            sb.AppendLine($"Vueltas Restantes: " +
                ((this.enCompetencia) ? this.vueltasRestantes.ToString() : "-"));
            sb.AppendLine($"Cantidad de combustible: {this.cantidadCombustible}");
            return sb.ToString();
        
        }
    }
}
