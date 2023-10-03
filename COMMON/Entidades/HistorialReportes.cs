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
        public int idReporte { get; set; }
        public string nombreEmpleado { get; set; }
        public DateTime fechaSolicitud { get; set; }
        public string motivoPermiso { get; set; }
        public int diasAusente { get; set; }
        public string estadoSolicitud { get; set; }
        public string Archivo { get; set; }


    }
}
