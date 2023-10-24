using COMMON.Entidades;
using DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentosController : GenericController<Departamentos>
    {
        public DepartamentosController() : base(FabricRepository.RepositorioDepartamentos())
        {

        }
        [HttpGet("ObtenerDepartamentos")]
        public ActionResult<List<Departamentos>> ObtenerDepartamentos()
        {
            try
            {
                var r = repositorio.Query<Departamentos>("Select * from Departamentos");
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
