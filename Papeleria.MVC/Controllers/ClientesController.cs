using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Papeleria.AccesoDatos.EF;
using Papeleria.LogicaAplicacion.ImplementacionCasosUso.Clientes;
using Papeleria.LogicaAplicacion.InterfacesCasosUso.Clientes;
using Papeleria.LogicaNegocio.InterfacesRepositorio;

namespace Papeleria.MVC.Controllers
{
    public class ClientesController : Controller
    {
        private static IRepositorioPedido _pedidos = new RepositorioPedidoEF(new PapeleriaContext());
        private static IRepositorioCliente _clientesRepo = new RepositorioClienteEF(new PapeleriaContext(), _pedidos);
        private static IBuscarClientes _buscarClientes;

        public ClientesController()
        {
            _buscarClientes = new BuscarClientes(_clientesRepo);
        }
        // GET: ClientesController
        public ActionResult Index()
        {
            if (HttpContext.Session.GetInt32("LogueadoID") != null)
            {
                var clientes = _buscarClientes.GetAll();
                if (clientes == null || clientes.Count() == 0)
                {
                    ViewBag.Mensaje = "No existen clientes";
                }
                ViewBag.Mensaje = $"Clientes en total: {clientes.Count()}.";
                return View(clientes);
            }
            return RedirectToAction("Index", "Home");
        }

        //[HttpPost]
        //public IActionResult Index(string razonSocial)
        //{

        //    TempData["ResultadoBuscarCliente"] = "";
        //    try
        //    {
        //        if (!string.IsNullOrEmpty(razonSocial))
        //        {
        //            var clienteRazonSocial = _buscarClientes.GetXRazonSocial(razonSocial);
        //            if (clienteRazonSocial == null)
        //            {
        //                TempData["ResultadoBuscarClientes"] = "No se ha encontrado ninguna coincidencia.";
        //                return RedirectToAction("Index", "Clientes");
        //            }
        //            return View(clienteRazonSocial);
        //        }
        //        else
        //        {
        //            TempData["ResultadoBuscarClientes"] = "No se encontraron coincidencias de busqueda";
        //            return RedirectToAction("Index", "Clientes");
        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        TempData["ResultadoBuscarClientes"] = e.Message;
        //        return RedirectToAction("Index", "Clientes");
        //    }

        //}

        [HttpPost]
        public IActionResult Index(string razonSocial, double? monto, string submitButton)
        {
            TempData["ResultadoBuscarCliente"] = "";
            try
            {
                if (!string.IsNullOrEmpty(submitButton))
                {
                    if (submitButton == "Filtrar X Razon")
                    {
                        if (!string.IsNullOrEmpty(razonSocial))
                        {
                            var clienteRazonSocial = _buscarClientes.GetXRazonSocial(razonSocial);
                            if (clienteRazonSocial == null)
                            {
                                TempData["ResultadoBuscarClientes"] = "No se ha encontrado ninguna coincidencia para esa razon social.";
                                return RedirectToAction("Index", "Clientes");
                            }
                            return View("Details",clienteRazonSocial);
                        }
                        else
                        {
                            TempData["ResultadoBuscarClientes"] = "No se encontraron coincidencias de búsqueda.";
                            return RedirectToAction("Index", "Clientes");
                        }
                    }
                    else if (submitButton == "Filtrar X Monto")
                    {
                        if (monto != null)
                        {
                            var clientesSuperaronMonto = _buscarClientes.GetXMontoSuperado(monto.Value);
                            if (clientesSuperaronMonto.Any())
                            {
                                TempData["ResultadoBuscarClientes"] = "No se ha encontrado ninguna coincidencia para ese monto.";
                            }
                            return View(clientesSuperaronMonto);
                        }
                        else
                        {
                            TempData["ResultadoBuscarClientes"] = "Ocurrió un error en la búsqueda";
                            return RedirectToAction("Index", "Clientes");
                        }
                    }
                }
                TempData["ResultadoBuscarClientes"] = "No se ha encontrado ninguna coincidencia.";
                return RedirectToAction("Index", "Clientes");
            }
            catch (Exception e)
            {
                TempData["ResultadoBuscarClientes"] = e.Message;
                return RedirectToAction("Index", "Clientes");
            }
        }




        // GET: ClientesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClientesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: ClientesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientesController/Edit/5
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

        // GET: ClientesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientesController/Delete/5
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
    }
}
