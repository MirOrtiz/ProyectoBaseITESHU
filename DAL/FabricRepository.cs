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
        //public static string urlBase = @"http://MarpaApp.somee.com";
        private static string cadenaConexion = @"workstation id = MarpaApp.mssql.somee.com; packet size = 4096; user id = MirOrtiz_SQLLogin_1; pwd=hxxatwkfmw;data source = MarpaApp.mssql.somee.com; persist security info=False;initial catalog = MarpaApp; TrustServerCertificate=true";
       
        public static IRepositorio<Perfil> RepositorioPerfil() => new Repositorio<Perfil>(cadenaConexion, new PerfilValidator());
        public static IRepositorio<Permisos> RepositorioPermisos() => new Repositorio<Permisos>(cadenaConexion, new PermisosValidator());
        public static IRepositorio<Calendarizacion> RepositorioCalendarizacion() => new Repositorio<Calendarizacion>(cadenaConexion, new CalendarizacionValidator());
        public static IRepositorio<Departamentos> RepositorioDepartamento() => new Repositorio<Departamentos>(cadenaConexion, new DepartamentosValidator());
        public static IRepositorio<DetallePermiso> RepositorioDetallePermiso() => new Repositorio<DetallePermiso>(cadenaConexion, new DetallePermisoValidator());

    }

}
