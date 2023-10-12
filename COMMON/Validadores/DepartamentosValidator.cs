using COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Validadores
{
    public class DepartamentosValidator:BaseValidator<Departamentos>
    {
        public DepartamentosValidator()
        {
            RuleFor(d => d.idDpto).NotEmpty();
            RuleFor(d => d.nombreDpto).NotEmpty();
            RuleFor(d => d.responsableDpto).NotEmpty();
           
        }
    }
}
