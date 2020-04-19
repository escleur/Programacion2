using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Libro
    {
        List<string> paginas;

        public string this[int i]
        {
            get
            {
                if(i>=0 && i<paginas.Count)
                {
                    return paginas[i];
                }
                else
                {
                    return "";
                }
            }
            set
            {
                if (this.paginas is null)
                {
                    paginas = new List<string>();
                }
                if (i>=0 && i < paginas.Count)
                {
                    paginas[i] = value;
                }
                else
                {
                    paginas.Add(value);
                }
            }
        }
    }
}
