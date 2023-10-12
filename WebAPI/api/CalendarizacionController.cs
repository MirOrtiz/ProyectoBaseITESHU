using COMMON.Entidades;
using DAL;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalendarizacionController : GenericController<Calendarizacion>
    {
        public CalendarizacionController() : base(FabricRepository.RepositorioCalendarizacion())
        {

        }
        [HttpGet("ObtenerCalendarizacion")]
        public ActionResult<List<Calendarizacion>> ObtenerCalendarizacion()
        {
            try
            {
                var r = repositorio.Query<Calendarizacion>("Select * from Calandarizacion");
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
    }                   //aniosTabajo no debe estar vacio, asignar mas permisos
                        //Error en fechaIngreso corregir 
}
