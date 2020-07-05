using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic.Comun
{
    public static class Extension
    {
        public static string FormatearPrecio(this Double precio)
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("${0,10:###,###.00}");
            return sb.ToString();


        }
    }
}
