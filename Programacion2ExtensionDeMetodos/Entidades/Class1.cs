using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum Estaciones { Verano, Primavera, Invierno, Otonio}
    public static class Class1
    {
        public static string ObtenerPlacaCronica(this DateTime fecha, Estaciones estacion)
        {
            int day = 21;
            int mes = 0;
            string est = "";
            switch (estacion)
            {
                case Estaciones.Invierno:
                    est = "el invierno";
                    mes = 6;
                    break;
                case Estaciones.Primavera:
                    est = "la primavera";
                    mes = 9;
                    break;
                case Estaciones.Verano:
                    est = "el verano";
                    mes = 12;
                    break;
                case Estaciones.Otonio:
                    est = "el otonio";
                    mes = 3;
                    break;
            }
            DateTime fechaEvento = new DateTime(fecha.Year, mes, day);
            if(fechaEvento < fecha)
            {
                fechaEvento.AddYears(1);
            }
            int cantidadDias = (int)(fechaEvento - fecha).TotalDays;
            return $"Faltan {cantidadDias} dias para {est}.";
        }
    }
}
