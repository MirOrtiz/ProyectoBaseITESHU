using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Entidades
{
    public class Permisos:Base
    {
        public int idPermiso { get; set; }
        public DateOnly fecha { get; set; }
        public string nombre { get; set; }
        public string clave { get; set; }
        public string departamento { get; set; }
        public string permisoPor { get; set; }
        public string dias { get; set; }
        public string horas { get; set; }
        public int diasAusente { get; set; }
        public DateOnly fecha1 { get; set; }
        public DateOnly fecha2 { get; set; }
        public string horasAusente { get; set; }
        public DateTime hora1 { get; set; }
        public DateTime hora2 { get; set; }
        public string motivoPermiso { get; set; }
        public string permConSueldo { get; set; }
        public string permSinSueldo { get; set; }
    }
}
