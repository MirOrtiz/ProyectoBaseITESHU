using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Modelos
{
    public class ListaDepartamentoModel:ModelBase
    {
        public int idEmpleado { get; set; }
        public string departamento { get; set; }
        public string responsable { get; set; }
        public string motivoPermiso { get; set; }
        public string estadoSolicitud { get; set; }
    }
}
