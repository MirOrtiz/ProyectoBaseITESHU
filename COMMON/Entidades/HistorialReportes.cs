using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Entidades
{
    public class HistorialReportes:Base
    {
        // public int idEmpleado { get; set; }
        public int idHistReportes { get; set; }
        public DateOnly fecha { get; set; }
        public string nombre { get; set; }
        public string motivoPermiso { get; set; }
        public int diasAusente { get; set; }
        public string estadoSolicitud { get; set; }
        public string archivo { get; set; }


    }
}
