using COMMON.Entidades;
using COMMON.Interfaces;
using COMMON.Validadores;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DAL
{
    public static class FabricRepository
    {
        private static string cadenaConexion = @"workstation id=MarpaIT.mssql.somee.com;packet size = 4096; user id = MirOrtiz_SQLLogin_1; pwd=hxxatwkfmw;data source = MarpaIT.mssql.somee.com; persist security info=False;initial catalog = MarpaIT; TrustServerCertificate=true";

        public static IRepositorio<Perfil> RepositorioPerfil() => new Repositorio<Perfil>(cadenaConexion, new PerfilValidator());
        public static IRepositorio<Permisos> RepositorioPermisos() => new Repositorio<Permisos>(cadenaConexion, new PermisosValidator());
        public static IRepositorio<Reportes> RepositorioReportes() => new Repositorio<Reportes>(cadenaConexion, new ReportesValidator());
        public static IRepositorio<Calendarizacion> RepositorioCalendarizacion() => new Repositorio<Calendarizacion>(cadenaConexion, new CalendarizacionValidator());
        public static IRepositorio<Departamento> RepositorioDepartamento() => new Repositorio<Departamento>(cadenaConexion, new DepartamentoValidator());
        public static IRepositorio<ConfirmarPermiso> RepositorioConfirmacionPermiso() => new Repositorio<ConfirmarPermiso>(cadenaConexion, new ConfirmarPermisoValidator());
        public static IRepositorio<HistorialReportes> RepositorioHistorialReportes() => new Repositorio<HistorialReportes>(cadenaConexion, new HistorialReportesValidator());
        public static IRepositorio<Configuracion> RepositorioConfiguracion() => new Repositorio<Configuracion>(cadenaConexion, new ConfiguracionValidator());
    }

}
