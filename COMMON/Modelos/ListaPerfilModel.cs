using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Modelos
{
    public class ListaPerfilModel : ModelBase
    {
        public int Id { get; set; }
        public string nombreEmp { get; set; }
        public string claveEmp { get; set; }
        public string nombreDpto { get; set; }
        public string telefonoEmp{ get; set; }
        public string correoEmp{ get; set; }
        public DateTime fechaSolicitud { get; set; }
    }
}
