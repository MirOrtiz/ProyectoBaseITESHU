using COMMON.Entidades;
using COMMON.Validadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class CalendarizacionManager : GenericManager<Calendarizacion>
    {
        public CalendarizacionManager(string urlBase, BaseValidator<Calendarizacion> validador) : base(urlBase, validador)
        {
        }
    }
}
