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
            RuleFor(m=>m.nombreEmpleado).NotEmpty();
            RuleFor(m => m.numEmpleado).NotEmpty();
            RuleFor(m => m.departamento).NotEmpty();
            RuleFor(m => m.permisoPor).NotEmpty();
            RuleFor(m => m.dias).NotEmpty();
            RuleFor(m => m.horas).NotEmpty();
            RuleFor(m => m.diasAusente).NotEmpty();
            RuleFor(m => m.motivoPermiso).NotEmpty();

        }
    }
}
