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

        protected string Error { get; private set; }
        public GenericManager(string urlBase, BaseValidator<T> validador)
        {
            this.tabla=typeof(T).Name;
            this.urlBase=urlBase;
            this.httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(urlBase);
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

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
            return InsertarAsync(item).Result;
        }

        public T Actualizar(T item)
        {
            return ActualiarAsync(item).Result;
        }

        public bool Eliminar(int id)
        {
            return EliminarAsync(id).Result;
        }

        #endregion

        #region MetodosAsincronos
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
