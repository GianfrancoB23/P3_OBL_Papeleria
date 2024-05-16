using Empresa.LogicaDeNegocio.Entidades;
using Microsoft.AspNetCore.Mvc;
using Papeleria.AccesoDatos.EF;
using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Articulos;
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
        private IGetArticulo _cuGetArticulo;
        private IAltaArticulo _cuAltaArticulo;
        private IBorrarArticulo _cuBorrarArticulo;
        private IUpdateArticulo _cuModificarArticulo;

        public ArticulosController()
        {
            _repoArticulos = new RepositorioArticuloEF();
            _cuGetArticulos = new GetAllArticulos(_repoArticulos);
            _cuGetArticulo = new BuscarArticulo(_repoArticulos);
            _cuAltaArticulo = new AltaArticulo(_repoArticulos);
            _cuBorrarArticulo = new BorrarArticulo(_repoArticulos);
            _cuModificarArticulo = new UpdateArticulo(_repoArticulos);
        }
        // GET: api/<ArticulosController>
        [HttpGet]
        public ActionResult<IEnumerable<ArticuloDTO>> Get()
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
        [HttpGet("{id}", Name = "GetAutorByID")]
        public ActionResult<ArticuloDTO> Get(int id)
        {
            try
            {
                var articuloDto = _cuGetArticulo.GetById(id);
                return Ok(articuloDto);
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

        // POST api/<ArticulosController>
        [HttpPost]
        public ActionResult<ArticuloDTO> Post(ArticuloDTO articulo)
        {
            try
            {
                _cuAltaArticulo.Ejecutar(articulo);
                return CreatedAtRoute("GetAutorByID", new { id = articulo.Id }, articulo);
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

        // PUT api/<ArticulosController>/5
        [HttpPut("{id}")]
        public ActionResult<ArticuloDTO> Put(int id, ArticuloDTO articulo)
        {
            try
            {
                _cuModificarArticulo.Ejecutar(id, articulo);
                return Ok(articulo);
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

        // DELETE api/<ArticulosController>/5
        [HttpDelete("{id}")]
        public ActionResult<ArticuloDTO> Delete(int id)
        {
            try
            {
                _cuBorrarArticulo.Ejecutar(id);
                return Ok("foobar");
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
    }
}
