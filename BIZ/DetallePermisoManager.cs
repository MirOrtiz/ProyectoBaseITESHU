using COMMON.Entidades;
using COMMON.Validadores;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class DetallePermisoManager : GenericManager<DetallePermiso> 
    {
        public DetallePermisoManager(string urlBase, BaseValidator<DetallePermiso> validador) : base(urlBase, validador)
        {

        }
        public List<DetallePermiso> ObtenerDetallePermiso()
        {
            try
            {
                Error = " ";
                return ObtenerDetallePermisoAsync().Result;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }
        }
        private async Task<List<DetallePermiso>> ObtenerDetallePermisoAsync()
        {
            HttpResponseMessage response = await httpClient.GetAsync($"{urlBase}/api/{tabla}/ObtenerDetallePermiso").ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                Error = " ";
                return JsonConvert.DeserializeObject<List<DetallePermiso>>(content);
            }
            else
            {
                Error = content;
                return null;
            }
        }
    }
}
