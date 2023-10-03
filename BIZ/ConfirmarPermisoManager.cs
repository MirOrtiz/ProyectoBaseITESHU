using COMMON.Validadores;
using COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class ConfirmarPermisoManager : GenericManager<ConfirmarPermiso>
    {
        public ConfirmarPermisoManager(string urlBase, BaseValidator<ConfirmarPermiso> validador) : base(urlBase, validador)
        {
        }
    }
}
