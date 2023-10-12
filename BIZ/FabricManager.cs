using COMMON.Validadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public static class FabricManager
    {
       // public static string urlBase = @"http://localhost:5098";  
        public static string urlBase = @"http://MarpaApp.somee.com";
        
        

        public static PerfilManager PerfilManager() => new PerfilManager(urlBase, new PerfilValidator());
        public static PermisosManager PermisosManager() => new PermisosManager(urlBase, new PermisosValidator());
        public static CalendarizacionManager CalendarizacionManager() => new CalendarizacionManager(urlBase, new CalendarizacionValidator());
        public static DepartamentosManager DepartamentosManager() => new DepartamentosManager(urlBase, new DepartamentosValidator());
        public static DetallePermisoManager DetallePermisoManager() => new DetallePermisoManager(urlBase, new DetallePermisoValidator());




    }
}
