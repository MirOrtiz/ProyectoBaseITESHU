using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Entidades
{
    public class Permisos:Base
    {
        public int Id { get; set; }
        public DateTime fechaSolicitud { get; set; }
        public string tipoPermiso { get; set; }
        public DateTime periodoDiasInicio { get; set; }
        public DateTime periodoDiasFin { get; set; }
        public int cantidadDias { get; set; }
        public DateTime periodoHorasInicio { get; set; }
        public DateTime periodoHorasFin { get; set; }
        public int cantidadHoras { get; set; }     
        public string motivoPermiso { get; set; }
        public string estadoPermiso { get; set; }
    }
}