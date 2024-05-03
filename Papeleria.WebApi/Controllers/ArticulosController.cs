using Microsoft.AspNetCore.Mvc;
using Papeleria.AccesoDatos.EF;
using Papeleria.LogicaAplicacion.ImplementacionCasosUso.Articulos;
using Papeleria.LogicaAplicacion.InterfacesCasosUso.Articulos;
using Papeleria.LogicaNegocio.Excepciones.Articulo;
using Papeleria.LogicaNegocio.InterfacesRepositorio;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Papeleria.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticulosController : ControllerBase
    {
        private IRepositorioArticulo _repoArticulos;
        private IGetAllArticulos _cuGetArticulos;
        public ArticulosController()
        {
            _repoArticulos = new RepositorioArticuloEF(new PapeleriaContext());
            _cuGetArticulos = new GetAllArticulos(_repoArticulos);
        }
        // GET: api/<ArticulosController>
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            try
            {
                var articulosDto = _cuGetArticulos.Ejecutar();
                return Ok(articulosDto);
            }
            catch (ArticuloNoValidoException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        // GET api/<ArticulosController>/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/<ArticulosController>
        [HttpPost]
        public ActionResult<string> Post([FromBody] string value)
        {
            return Ok(value);
        }

        // PUT api/<ArticulosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ArticulosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
