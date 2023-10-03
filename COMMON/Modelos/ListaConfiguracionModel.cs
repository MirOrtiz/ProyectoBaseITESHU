using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Modelos
{
    public class ListaConfiguracionModel:ModelBase
    {
        public int idEmpleado { get; set; }
        public string diasVacaciones { get; set; }
        public string diasTomados { get; set; }
        public string diasRestantes { get; set; }
        public int aniosTrabajo { get; set; }
    }
}
