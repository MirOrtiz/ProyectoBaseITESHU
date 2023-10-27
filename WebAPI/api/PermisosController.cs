using COMMON.Entidades;
using COMMON.Modelos;
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
        public ActionResult<List<ListaPermisosModel>> ObtenerPermiso()
        {
            try
            {
                var r = repositorio.Query<ListaPermisosModel>("Select * from ListaPermisos");
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
