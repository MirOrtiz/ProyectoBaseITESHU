using COMMON.Entidades;
using DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : GenericController<Departamentos>
    {
        public DepartamentoController() : base(FabricRepository.RepositorioDepartamento())
        {

        }
        [HttpGet("ObtenerDepartamento")]
        public ActionResult<List<Departamentos>> ObtenerDepartamento()
        {
            try
            {
                var r = repositorio.Query<Departamentos>("Select * from Departamento");
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
