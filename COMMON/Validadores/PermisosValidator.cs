using COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Validadores
{
    public class PermisosValidator:BaseValidator<Permisos>
    {
        public PermisosValidator()
        {
            RuleFor(m => m.idPermiso).NotEmpty();
            RuleFor(m => m.fechaSolicitud).NotEmpty();
            RuleFor(m => m.tipoPermiso).NotEmpty();
            RuleFor(m => m.periodoDiasInicio).NotEmpty();
            RuleFor(m => m.periodoDiasFin).NotEmpty();
            RuleFor(m => m.cantidadDias).NotEmpty();
            RuleFor(m => m.periodoHorasInicio).NotEmpty();
            RuleFor(m => m.periodoHorasFin).NotEmpty();
            RuleFor(m => m.cantidadHoras).NotEmpty();
            RuleFor(m => m.motivoPermiso).NotEmpty();
            RuleFor(m => m.estadoPermiso).NotEmpty();
        }
    }
}
