using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Papeleria.AccesoDatos.EF;
using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Usuario;
using Papeleria.LogicaAplicacion.ImplementacionCasosUso.Usuarios;
using Papeleria.LogicaAplicacion.InterfacesCasosUso.Usuarios;
using Papeleria.LogicaNegocio.InterfacesRepositorio;

namespace Papeleria.MVC.Controllers
{
    public class UsuariosController : Controller
    {
        private static IRepositorioUsuario _repoUsuarios = new RepositorioUsuarioEF(new PapeleriaContext());
        private static IAltaUsuario _altaUsuario;
        private static IGetAllUsuarios _getAllUsuarios;
        public UsuariosController() { 
            _altaUsuario = new AltaUsuarios(_repoUsuarios);
            _getAllUsuarios = new GetAllUsuarios(_repoUsuarios);
        }
        // GET: UsuariosController
        public ActionResult Index()
        {
            var usuarios = _getAllUsuarios.Ejecutar();
            if (usuarios == null || usuarios.Count()==0) {
                ViewBag.Mensaje = "No existen usuarios";
            }
            ViewBag.Mensaje = $"Usuario creado - {usuarios.Count()} en total.";
            return View(usuarios);
        }

        // GET: UsuariosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsuariosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuariosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioAltaDto autorDto)
        {
            try
            {
                _altaUsuario.Ejecutar(autorDto);
                TempData["Mensaje"] = "Usuario creado";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }

        // GET: UsuariosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsuariosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuariosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuariosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        //TODO 2:22:26 - https://vimeopro.com/universidadortfi/fi-5212-programacion-3-cabella-69235-p3-m3a-remoto/video/929607409
    }
}
