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
            RuleFor(p => p.nombre).NotEmpty();
            RuleFor(p => p.clave).NotEmpty();
            RuleFor(p => p.departamento).NotEmpty();
            RuleFor(p => p.telefono).NotEmpty();
            RuleFor(p => p.correo).NotEmpty();
            RuleFor(p => p.fechaIngreso).NotEmpty();

        }
    }
}
