using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Modelos
{
    public class ListaPermisosModel : ModelBase 
    {
        public int Id { get; set; }
        public string nombreEmp { get; set; }
        public string claveEmp { get; set; }
        public string nombreDpto { get; set; }
        public DateTime fechaSolcitud { get; set; }
        public string tipoPermiso { get; set; }
        public DateTime periodoDiasInicio { get; set; }
        public DateTime periodoDiasFin { get; set; }
        public int cantidadDias { get; set; }
        public DateTime periodoHorasInicio { get; set; }
        public DateTime periodoHorasFin { get; set; }
        public int cantidadHoras { get; set; }
        public string motivoPermiso { get; set; }
        public string estadoPermiso { get; set; }
        public string conceptoPermiso { get; set; }
        public string permConSueldo { get; set; }
        public string permSinSueldo { get; set; }

    }
}
