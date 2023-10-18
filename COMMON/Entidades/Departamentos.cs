using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Entidades
{
    public class Departamentos:Base
    {
        public int Id { get; set; }
        public string nombreDpto { get; set; }
        public string responsableDpto { get; set; }
        
    }
}
