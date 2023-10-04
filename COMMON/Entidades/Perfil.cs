using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Entidades
{
    public class Perfil:Base
    {
        public int idEmpleado { get; set; }
        public string nombre { get; set; }
        public int clave { get; set; }
        public string departamento { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public DateOnly fechaIngreso { get; set; }

    }
}
