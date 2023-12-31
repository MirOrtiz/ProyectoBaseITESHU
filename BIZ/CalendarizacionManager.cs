﻿using COMMON.Entidades;
using COMMON.Validadores;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class CalendarizacionManager : GenericManager<Calendarizacion>
    {
        public CalendarizacionManager(string urlBase, BaseValidator<Calendarizacion> validador) : base(urlBase, validador)
        {
        }
        public List<Calendarizacion> ObtenerCalendarizacion()
        {
            try
            {
                Error = "";
                return ObtenerCalendarizacionAsync().Result;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;

            }
        }
        private async Task<List<Calendarizacion>> ObtenerCalendarizacionAsync()
        {
            HttpResponseMessage response = await httpClient.GetAsync($"{urlBase}/api/{tabla}/ObtenerCalendarizacion").ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                Error = "";
                return JsonConvert.DeserializeObject<List<Calendarizacion>>(content);
            }
            else
            {
                Error = content;
                return null;
            }
        }
    }
}
