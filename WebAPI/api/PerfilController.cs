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
        [HttpGet("ObtenerPerfil")]

        public ActionResult<List<Perfil>> ObtenerPerfil()
        {
            try
            {
                var r = repositorio.Query<Perfil>("Select * from Perfil");
                if(r != null)
                {
                    return Ok(r);
                }
                else
                {
                    return BadRequest(repositorio.Error);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(repositorio.Error);
            }
        }
       
    }
}
