using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.AccesoDatos.EF;
using Papeleria.LogicaAplicacion.ImplementacionCasosUso.Usuarios;
using Papeleria.LogicaAplicacion.InterfacesCasosUso.Usuarios;
using Papeleria.LogicaNegocio.InterfacesRepositorio;
using Papeleria.LogicaAplicacion.InterfacesCasosUso.Articulos;
using Papeleria.LogicaAplicacion.ImplementacionCasosUso.Articulos;

namespace Papeleria.MVC.Controllers
{
    public class ArticulosController : Controller
    {
        private static IRepositorioArticulo _repoArticulos = new RepositorioArticuloEF(new PapeleriaContext());
        private static IAltaArticulo _altaArticulo;
        private static IGetAllArticulos _getAllArticulos;
        private static IUpdateArticulo _modificarArticulo;
        private static IGetArticulo _getArticulo;
        private static IBorrarArticulo _borrarArticulo;


        public ArticulosController()
        {
            _altaArticulo = new AltaArticulo(_repoArticulos);
            _getAllArticulos = new GetAllArticulos(_repoArticulos);
            _modificarArticulo = new UpdateArticulo(_repoArticulos);
            _getArticulo = new BuscarArticulo(_repoArticulos);
            _borrarArticulo = new BorrarArticulo(_repoArticulos);
        }

        public ActionResult Index()
        {
            if (HttpContext.Session.GetInt32("LogueadoID") != null)
            {
                var articulo = _getAllArticulos.Ejecutar();
                if (articulo == null || articulo.Count() == 0)
                {
                    ViewBag.Mensaje = "No existen articulo";
                }
                ViewBag.Mensaje = $"Articulos en total: {articulo.Count()}.";
                return View(articulo);
            }
            return RedirectToAction("Index", "Home");
        }
    }      
}
