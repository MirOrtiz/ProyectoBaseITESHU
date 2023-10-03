using COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Validadores
{
    public class PerfilValidator:BaseValidator<Perfil>
    {
        public PerfilValidator() 
        {
            RuleFor(p => p.nombreEmpleado).NotEmpty();
            RuleFor(p => p.numEmpleado).NotEmpty();
            RuleFor(p => p.departamento).NotEmpty();
            RuleFor(p => p.telefono).NotEmpty();
            RuleFor(p => p.emailEmpleado).NotEmpty();

        }
    }
}
