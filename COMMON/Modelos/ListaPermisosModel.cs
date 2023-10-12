using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Modelos
{
    public class ListaPermisosModel : ModelBase 
    {
        public int idEmpleado { get; set; }
        public string nombreEmp { get; set; }
        public string clave { get; set; }
        public string NombreDpto { get; set; }
        public DateOnly fechaSolcitud { get; set; }
        public string tipoPermiso { get; set; }
        public DateOnly permisoDiasInicio { get; set; }
        public DateOnly permisoDiasFin { get; set; }
        public int cantidadDias { get; set; }
        public DateOnly permisoHorasInicio { get; set; }
        public DateOnly permisohorasFin { get; set; }
        public int cantidadHoras { get; set; }
        public string motivoPermiso { get; set; }
        public string estadoPermiso { get; set; }
        public string conceptoPermiso { get; set; }
        public string permConSueldo { get; set; }
        public string permSinSueldo { get; set; }

    }
}
