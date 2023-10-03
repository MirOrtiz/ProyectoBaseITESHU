using COMMON.Entidades;
using COMMON.Validadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class ReportesManager : GenericManager<Reportes>
    {
        public ReportesManager(string urlBase, BaseValidator<Reportes> validador) : base(urlBase, validador)
        {
        }
    }
}
