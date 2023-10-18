using COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Validadores
{
    public class DetallePermisoValidator : BaseValidator<DetallePermiso>
    {
        public DetallePermisoValidator()
        {
            RuleFor(t => t.Id).NotEmpty();
            RuleFor(t => t.conceptoPermiso).NotEmpty();
            RuleFor(t => t.permConSueldo).NotEmpty();
            RuleFor(t => t.permSinSueldo).NotEmpty();
           
        }
    }
}
