using COMMON.Entidades;
using COMMON.Interfaces;
using COMMON.Validadores;
using DAL;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.api
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class GenericController<T> : ControllerBase where T : Base
    {
        // GET: api/<GenericController>

        protected IRepositorio<T> repositorio;
        public GenericController(IRepositorio<T> repo)
        {
            repositorio = repo;
        }
        [HttpGet]
        public ActionResult<List<T>> Get()
        {
            var datos = repositorio.Get;
            return datos != null ? Ok(datos) : BadRequest(repositorio.Error);
        }

        // GET api/<GenericController>/5
        [HttpGet("{id}")]
        public ActionResult<T> Get(int id)
        {
            var datos = repositorio.GetById(id);
            return datos!=null?Ok(datos):BadRequest(repositorio.Error);
        }

        // POST api/<GenericController>
        [HttpPost]
        public ActionResult<T> Post([FromBody] T value)
        {
            var datos = repositorio.Insert(value);
            return datos != null ? Ok(datos) : BadRequest(repositorio.Error);
        }

        // PUT api/<GenericController>/5
        [HttpPut]
        public ActionResult<T> Put([FromBody] T value)
        {
            var datos = repositorio.Update(value);
            return datos != null ? Ok(datos) : BadRequest(repositorio.Error);
        }

        // DELETE api/<GenericController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            var result=repositorio.Delete(id);
            return result?result: BadRequest(repositorio.Error);
        }
    }
}
