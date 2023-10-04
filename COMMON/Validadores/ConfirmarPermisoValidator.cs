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
            RuleFor(c => c.fecha).NotEmpty();
            RuleFor(c => c.idConfPermiso).NotEmpty();
            RuleFor(c => c.nombre).NotEmpty();
            RuleFor(c => c.clave).NotEmpty();
            RuleFor(c => c.departamento).NotEmpty();
            RuleFor(c => c.permisoPor).NotEmpty();
            RuleFor(c => c.dias).NotEmpty();
            RuleFor(c => c.horas).NotEmpty();
            RuleFor(c => c.diasAusente).NotEmpty();
            RuleFor(c => c.fecha1).NotEmpty();
            RuleFor(c => c.fecha2).NotEmpty();
            RuleFor(c => c.horasAusente).NotEmpty();
            RuleFor(c => c.hora1).NotEmpty();
            RuleFor(c => c.hora2).NotEmpty();
            RuleFor(c => c.motivoPermiso).NotEmpty();
            RuleFor(c => c.permisoConSueldo).NotEmpty();
            RuleFor(c => c.permisoSinSueldo).NotEmpty();


        }
    }
}
