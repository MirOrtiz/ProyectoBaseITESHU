using COMMON.Entidades;
using COMMON.Validadores;
using Newtonsoft.Json;
using System.Text;


namespace BIZ
{
    public abstract class GenericManager<T> where T : Base
    {
        protected string tabla { get; private set; }
        protected string urlBase { get; private set; }
        protected HttpClient httpClient { get; private set; }
        
        protected BaseValidator<T> validator;

        public string Error { get; protected set; }
        public GenericManager(string urlBase, BaseValidator<T> validador)
        {
            this.tabla=typeof(T).Name;
            this.urlBase=urlBase;
            this.httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(urlBase);
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            validator = validador;

        }

        #region MetodoCRUD
        public List<T> ObtenerTodos
        {
            get
            {
                try
                {
                    Error = "";
                    return ObtenerTodosAsync().Result;
                }
                catch (Exception ex)
                {
                    Error = ex.Message;
                    return null;
                }
            }
        }

        public T Insertar(T item)
        {
            //item.idEmpleado = 1;

            var r = validator.Validate(item);
            if (r.IsValid)
            {
                return InsertarAsync(item).Result;
            }
            else
            {
                Error = "Errores de Validación: ";
                foreach (var error in r.Errors)
                {
                    Error += error + " ";
                }
                item.idEmpleado = 0;
                return null;
            }

        }

        public T Actualizar(T item)
        {
            var r = validator.Validate(item);
            if (r.IsValid)
            {
                return ActualiarAsync(item).Result;
            }
            else
            {
                Error = "Errores de Validacion: ";
                foreach (var error in r.Errors)
                {
                    Error += error;
                }
                return null;
            }
        }

        public bool Eliminar(int id)
        {
            return EliminarAsync(id).Result;
        }

        public T ObtenerPorId(int id)
        {
            return ObtenerPorIdAsync(id).Result;
        }
        #endregion

        #region MetodosAsincronos


        private async Task<T> ObtenerPorIdAsync(int id)
        {
            HttpResponseMessage response = await httpClient.GetAsync($"{urlBase}/api/{tabla}/{id}").ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                Error = "";
                return JsonConvert.DeserializeObject<T>(content);
            }
            else
            {
                Error = content;
                return null;
            }
        }
        public async Task<List<T>> ObtenerTodosAsync()
        {
            HttpResponseMessage response = await httpClient.GetAsync($"{urlBase}/api/{tabla}").ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                Error = "";
                return JsonConvert.DeserializeObject<List<T>>(content);
            }
            else
            {
                Error = content;
                return null;
            }
        }

        public async Task<T> InsertarAsync(T item)
        {
            var c = JsonConvert.SerializeObject(item);
            var body = new StringContent(c, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync($"{urlBase}/api/{tabla}", body).ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                Error = "";
                return JsonConvert.DeserializeObject<T>(content);
            }
            else
            {
                Error = content;
                return null;
            }
        }

        public async Task<T> ActualiarAsync(T item)
        {
            var c = JsonConvert.SerializeObject(item);
            var body = new StringContent(c, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PutAsync($"{urlBase}/api/{tabla}", body).ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                Error = "";
                return JsonConvert.DeserializeObject<T>(content);
            }
            else
            {
                Error = content;
                return null;
            }
        }

        public async Task<bool> EliminarAsync(int id)
        {
            HttpResponseMessage response = await httpClient.DeleteAsync($"{urlBase}/api/{tabla}/{id}").ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                Error = "";
                return true;
            }
            else
            {
                Error = content;
                return false;
            }
        }



        #endregion
    }
}
