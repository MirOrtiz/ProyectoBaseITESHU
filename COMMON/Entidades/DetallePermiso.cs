using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Entidades
{
    public class DetallePermiso:Base
    {
        public int idDetalle { get; set; }
        public string conceptoPermiso { get; set; }
        public string permConSueldo { get; set; }
        public string permSinSueldo { get; set; }

    }
}
