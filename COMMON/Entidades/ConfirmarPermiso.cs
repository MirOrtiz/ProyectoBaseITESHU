using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Entidades
{
    public class ConfirmarPermiso:Base
    {
        //public int idEmpleado { get; set; }
        public string nombreEmpleado { get; set; }
        public int numEmpleado { get; set; }
        public string departamento { get; set; }
        public string permisoPor { get; set; }
        public DateOnly dias { get; set; }
        public DateTime horas { get; set; }
        public int diasAusente { get; set; }
        public string motivoPermiso { get; set; }

    }
    
}
