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
            RuleFor(m=>m.idPermiso).NotEmpty();
            RuleFor(m => m.fecha).NotEmpty();
            RuleFor(m=>m.nombre).NotEmpty();
            RuleFor(m => m.clave).NotEmpty();
            RuleFor(m => m.departamento).NotEmpty();
            RuleFor(m => m.permisoPor).NotEmpty();
            RuleFor(m => m.dias).NotEmpty();
            RuleFor(m => m.horas).NotEmpty();
            RuleFor(m => m.diasAusente).NotEmpty();
            RuleFor(m => m.fecha1).NotEmpty();
            RuleFor(m => m.fecha2).NotEmpty();
            RuleFor(m => m.horasAusente).NotEmpty();
            RuleFor(m => m.hora1).NotEmpty();
            RuleFor(m => m.hora2).NotEmpty();
            RuleFor(m => m.motivoPermiso).NotEmpty();
            RuleFor(m => m.permConSueldo).NotEmpty();
            RuleFor(m => m.permSinSueldo).NotEmpty();


        }
    }
}
