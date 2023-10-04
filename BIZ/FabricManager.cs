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
       // public static string urlBase = @"http://localhost:9999";
        public static string urlBase = @"http://marpaapp.somee.com";
        

        public static PerfilManager PerfilManager() => new PerfilManager(urlBase, new PerfilValidator());
        public static PermisosManager PermisosManager() => new PermisosManager(urlBase, new PermisosValidator());
        public static ReportesManager ReportesManager() => new ReportesManager(urlBase, new ReportesValidator());
        public static CalendarizacionManager CalendarizacionManager() => new CalendarizacionManager(urlBase, new CalendarizacionValidator());
        public static DepartamentoManager DepartamentoManager() => new DepartamentoManager(urlBase, new DepartamentoValidator());
        public static ConfirmarPermisoManager ConfirmarPermisoManager() => new ConfirmarPermisoManager(urlBase, new ConfirmarPermisoValidator());
        public static HistorialReportesManager HistorialReportesManager() => new HistorialReportesManager(urlBase, new HistorialReportesValidator());
        public static ConfiguracionManager ConfiguracionManager() => new ConfiguracionManager(urlBase, new ConfiguracionValidator());



    }
}
