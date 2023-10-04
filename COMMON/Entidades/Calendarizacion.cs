using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Entidades
{
    public class Calendarizacion:Base
    {
        public int idCalendar { get; set; }
        public string diasVacaciones { get; set; }
        public string diasTomados { get; set; }
        public string diasRestantes { get; set; }
        public int aniosTrabajo { get; set; }
        public DateOnly fechaIngreso { get; set; }
    }
}
