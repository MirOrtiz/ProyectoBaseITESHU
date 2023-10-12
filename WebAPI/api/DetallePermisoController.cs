using COMMON.Entidades;
using DAL;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetallePermisoController : GenericController<DetallePermiso>
    {
        public DetallePermisoController() : base(FabricRepository.RepositorioDetallePermiso())
        {

        }
        [HttpGet("ObtenerDetallePermiso")]
        public ActionResult<List<DetallePermiso>> ObtenerDetallePermiso()
        {
            try
            {
                var r = repositorio.Query<DetallePermiso>("Select * from DetallePermiso");
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
