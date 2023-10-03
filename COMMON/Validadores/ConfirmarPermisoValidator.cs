using COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Validadores
{
    public class ConfirmarPermisoValidator:BaseValidator<ConfirmarPermiso>
    {
        public ConfirmarPermisoValidator()
        {
            RuleFor(c => c.nombreEmpleado).NotEmpty();
            RuleFor(c => c.numEmpleado).NotEmpty();
            RuleFor(c => c.departamento).NotEmpty();
            RuleFor(c => c.permisoPor).NotEmpty();
            RuleFor(c => c.dias).NotEmpty();
            RuleFor(c => c.horas).NotEmpty();
            RuleFor(c => c.diasAusente).NotEmpty();
            RuleFor(c => c.motivoPermiso).NotEmpty();

        }
    }
}
