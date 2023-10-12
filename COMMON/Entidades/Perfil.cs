using Microsoft.VisualBasic;
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
        public string claveEmp { get; set; }
        public string nombreEmp { get; set; }
        public string telefonoEmp { get; set; }
        public string correoEmp { get; set; }
        public DateOnly fechaIngreso { get; set; }

    }
}



        //Se cambiaron los DateOnly por los DateFormat, en entidades permiso y perfil