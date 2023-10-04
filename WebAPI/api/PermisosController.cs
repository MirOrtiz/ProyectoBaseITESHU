using COMMON.Entidades;
using DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace WebAPI.api
{
    [Route("api/[controller]")]
    [ApiController]

    public class PermisosController : GenericController<Permisos>
    {
        public PermisosController() : base(FabricRepository.RepositorioPermisos())
        {

        }
        [HttpGet("ObtenerPermiso")]
        public ActionResult<List<Permisos>> ObtenerPermisos()
        {
            try
            {
                var r = repositorio.Query<Permisos>("Select * from Permisos");
                if (r != null)
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
