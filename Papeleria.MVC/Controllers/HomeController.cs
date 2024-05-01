using Empresa.LogicaDeNegocio.Sistema;
using Microsoft.AspNetCore.Mvc;
using Papeleria.AccesoDatos.EF;
using Papeleria.LogicaNegocio.InterfacesRepositorio;
using Papeleria.MVC.Models;
using System.Diagnostics;

namespace Papeleria.MVC.Controllers
{
    public class HomeController : Controller
    {
        private static IRepositorioUsuario _repoUsuarios = new RepositorioUsuarioEF(new PapeleriaContext());

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("LogueadoID") != null)
            {
                return RedirectToAction("Index", "Usuarios");

            }
            else
            {
                return View();
            }
        }

        public IActionResult Login()
        {
            if (HttpContext.Session.GetInt32("LogueadoID") != null)
            {
                return RedirectToAction("Index", "Publicacion");
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult Login(string Email, string Contrasenia)
        {
            Usuario usuLogin = _repoUsuarios.Login(Email, Contrasenia);
            if (usuLogin != null)
            {
                HttpContext.Session.SetInt32("LogueadoID", usuLogin.Id);
                HttpContext.Session.SetString("LogueadoEmail", usuLogin.Email.Direccion);
                return RedirectToAction("Index", "Usuarios");
            }
            else
            {
                TempData["Error"] = "Error en los datos ingresados";
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult Logout()
        {
            if (HttpContext.Session.GetInt32("LogueadoID") != null)
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Index", "Home");

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
