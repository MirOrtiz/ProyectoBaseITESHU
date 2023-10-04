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
            RuleFor(r => r.idHistReportes).NotEmpty();
            RuleFor(r => r.nombre).NotEmpty();
            RuleFor(r => r.fecha).NotEmpty();
            RuleFor(r => r.motivoPermiso).NotEmpty();
            RuleFor(r => r.diasAusente).NotEmpty();
            RuleFor(r => r.estadoSolicitud).NotEmpty();
            RuleFor(r => r.archivo).NotEmpty();

        }
    }
}
