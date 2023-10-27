using COMMON.Entidades;
using COMMON.Modelos;
using COMMON.Validadores;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class PermisosManager : GenericManager<Permisos>
    {
        public PermisosManager(string urlBase, BaseValidator<Permisos> validador) : base(urlBase, validador)
        {
        }
        public List<ListaPermisosModel> ObtenerPermiso()
        {
            try
            {
                Error = "";
                return ObtenerPermisoAsync().Result;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }
        }
        private async Task<List<ListaPermisosModel>> ObtenerPermisoAsync()
        {
            HttpResponseMessage response = await httpClient.GetAsync($"{urlBase}/api/{tabla}/ObtenerPermiso").ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                Error = "";
                return JsonConvert.DeserializeObject<List<ListaPermisosModel>>(content);
            }
            else
            {
                Error = content;
                return null;
            }
        }
    }
}
