using COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Validadores
{
    public class DepartamentoValidator:BaseValidator<Departamento>
    {
        public DepartamentoValidator()
        {
            RuleFor(d => d.departamento).NotEmpty();
            RuleFor(d => d.responsable).NotEmpty();
            RuleFor(d => d.motivoPermiso).NotEmpty();
            RuleFor(d => d.estadoSolicitud).NotEmpty();

        }
    }
}
