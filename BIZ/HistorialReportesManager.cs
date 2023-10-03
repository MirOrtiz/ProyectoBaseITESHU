using COMMON.Entidades;
using COMMON.Validadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class HistorialReportesManager : GenericManager<HistorialReportes>
    {
        public HistorialReportesManager(string urlBase, BaseValidator<HistorialReportes> validador) : base(urlBase, validador)
        {
        }
    }
}
