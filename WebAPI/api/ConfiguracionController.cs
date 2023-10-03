using COMMON.Entidades;
using DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfiguracionController : GenericController<Configuracion>
    {
        public ConfiguracionController() : base(FabricRepository.RepositorioConfiguracion())
        {

        }
    }
}
