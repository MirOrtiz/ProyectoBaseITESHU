using COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Validadores
{
    public abstract class BaseValidator<T>:AbstractValidator<T> where T : Base
    {
        public BaseValidator()
        {
            RuleFor(e=>e.idEmpleado).NotEmpty().GreaterThan(0);
            //RuleFor(e => e.FechaHora).NotEmpty();
        }
    }
}
