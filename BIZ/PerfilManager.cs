using COMMON.Entidades;
using COMMON.Validadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class PerfilManager : GenericManager<Perfil>
    {
        public PerfilManager(string urlBase, BaseValidator<Perfil> validador) : base(urlBase, validador)
        {
        }
    }
}
