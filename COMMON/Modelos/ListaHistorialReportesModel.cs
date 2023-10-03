using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Modelos
{
    public class ListaHistorialReportesModel:ModelBase
    {
        public int idReporte { get; set; }
        public int idEmpleado { get; set; }
        public string nombreEmpleado { get; set; }
        public DateTime fechaSolicitud { get; set; }
        public string motivoPermiso { get; set; }
        public int diasAusente { get; set; }
        public string estadoSolicitud { get; set; }
        public string Archivo { get; set; }
    }
}
