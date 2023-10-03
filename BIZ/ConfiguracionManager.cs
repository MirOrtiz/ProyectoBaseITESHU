using COMMON.Entidades;
using COMMON.Validadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class ConfiguracionManager : GenericManager<Configuracion>
    {
        public ConfiguracionManager(string urlBase, BaseValidator<Configuracion> validador) : base(urlBase, validador)
        {
        }
    }
}
