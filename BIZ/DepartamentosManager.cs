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
    public class DepartamentosManager : GenericManager<Departamentos>
    {
        public DepartamentosManager(string urlBase, BaseValidator<Departamentos> validador) : base(urlBase, validador)
        {
        }
        public List<Departamentos> ObtenerDepartamento()
        {
            try
            {
                Error = "";
                return ObtenerDepartamentoAsync().Result;
            }
            catch(Exception ex)
            {
                Error = ex.Message;
                return null;
            }
        }
        private async Task<List<Departamentos>> ObtenerDepartamentoAsync()
        {
            HttpResponseMessage response = await httpClient.GetAsync($"{urlBase}/api/{tabla}/ObtenerDepartamento").ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                Error = "";
                return JsonConvert.DeserializeObject<List<Departamentos>>(content);
            }
            else
            {
                Error = content;
                return null;
            }
        }
    }
}
