using COMMON.Entidades;
using DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace WebAPI.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerfilController : GenericController<Perfil>
    {
        public PerfilController() : base(FabricRepository.RepositorioPerfil())
        {

        }
    }
}
