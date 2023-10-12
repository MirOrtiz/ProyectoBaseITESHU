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
            RuleFor(p => p.idEmpleado).NotEmpty();
            RuleFor(p => p.nombreEmp).NotEmpty();
            RuleFor(p => p.claveEmp).NotEmpty();
            RuleFor(p => p.telefonoEmp).NotEmpty();
            RuleFor(p => p.correoEmp).NotEmpty();
            RuleFor(p => p.fechaIngreso).NotEmpty();

        }
    }
}
