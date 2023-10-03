using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Modelos
{
    public class ListaPerfilModel:ModelBase
    {
        public int idEmpleado { get; set; }
        public string nombreEmpleado { get; set; }
        public int numEmpleado { get; set; }
        public string departamento { get; set; }
        public string telefono { get; set; }
        public string emailEmpleado { get; set; }

    }
}
