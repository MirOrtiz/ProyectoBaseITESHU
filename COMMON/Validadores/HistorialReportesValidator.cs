using COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Validadores
{
    public class HistorialReportesValidator:BaseValidator<HistorialReportes>
    {
        public HistorialReportesValidator()
        {
          //RuleFor(r => r.idReporte).NotEmpty();
            RuleFor(r => r.nombreEmpleado).NotEmpty();
            RuleFor(r => r.fechaSolicitud).NotEmpty();
            RuleFor(r => r.motivoPermiso).NotEmpty();
            RuleFor(r => r.diasAusente).NotEmpty();
            RuleFor(r => r.estadoSolicitud).NotEmpty();
            RuleFor(r => r.Archivo).NotEmpty();

        }
    }
}
