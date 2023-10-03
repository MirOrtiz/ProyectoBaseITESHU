using COMMON.Entidades;
using COMMON.Validadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class PermisosManager : GenericManager<Permisos>
    {
        public PermisosManager(string urlBase, BaseValidator<Permisos> validador) : base(urlBase, validador)
        {
        }
    }
}
