using COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Validadores
{
    public class ReportesValidator:BaseValidator<Reportes>
    {
        public ReportesValidator() 
        {
            RuleFor(r => r.idReporte).NotEmpty();
            RuleFor(r => r.reportesDias).NotEmpty();
            RuleFor(r => r.reportesRestantes).NotEmpty();
            RuleFor(r => r.reportesAnios).NotEmpty();

        }

    }
}
