using COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Validadores
{
    public class CalendarizacionValidator:BaseValidator<Calendarizacion>
    {
        public CalendarizacionValidator()
        {
            RuleFor(c => c.Id).NotEmpty();
            RuleFor(c => c.diasVacaciones).NotEmpty();
            RuleFor(c => c.diasTomados).NotEmpty();
            RuleFor(c => c.diasRestantes).NotEmpty();
            RuleFor(c => c.aniosTrabajo).NotEmpty();
          
        }
    }
}
