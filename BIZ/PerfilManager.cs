using COMMON.Entidades;
using COMMON.Modelos;
using COMMON.Validadores;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class PerfilManager : GenericManager<Perfil>
    {
        public PerfilManager(string urlBase, BaseValidator<Perfil> validador) : base(urlBase, validador)
        {
        }
        public List<ListaPerfilModel> ObtenerPerfil()
        {
            try
            {
                Error = " ";
                return ObtenerPerfilAsync().Result;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }
        }
        private async Task<List<ListaPerfilModel>> ObtenerPerfilAsync()
        {
            HttpResponseMessage response = await httpClient.GetAsync($"{urlBase}/api/{tabla}/ObtenerPerfil").ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                Error = " ";
                return JsonConvert.DeserializeObject<List<ListaPerfilModel>>(content);
            }
            else
            {
                Error = content;
                return null;
            }
        }
    } 
}



    


   

