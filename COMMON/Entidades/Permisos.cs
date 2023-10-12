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
        public int idPermiso { get; set; }
        public DateOnly fechaSolicitud { get; set; }
        public string tipoPermiso { get; set; }
        public DateOnly periodoDiasInicio { get; set; }
        public DateOnly periodoDiasFin { get; set; }
        public int cantidadDias { get; set; }
        public DateOnly periodoHorasInicio { get; set; }
        public DateOnly periodoHorasFin { get; set; }
        public int cantidadHoras { get; set; }     
        public string motivoPermiso { get; set; }
        public string estadoPermiso { get; set; }
    }
}



    //Se cambio el DateOnly por DateFormat en la clase Permisos y Perfil
