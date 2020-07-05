using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaLogic.Interfaces
{
    public interface IEspecialista
    {
        /// <summary>
        /// 1 para db 2 para xml
        /// </summary>
        int NroClinica { get; }
        int Id { get; set; }

    }
}
