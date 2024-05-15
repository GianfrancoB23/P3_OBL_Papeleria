using Empresa.LogicaDeNegocio.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Papeleria.AccesoDatos.EF;
using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Articulos;
using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Pedidos;
using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Usuarios;
using Papeleria.LogicaAplicacion.ImplementacionCasosUso.Articulos;
using Papeleria.LogicaAplicacion.ImplementacionCasosUso.Clientes;
using Papeleria.LogicaAplicacion.ImplementacionCasosUso.Pedidos;
using Papeleria.LogicaAplicacion.InterfacesCasosUso.Articulos;
using Papeleria.LogicaAplicacion.InterfacesCasosUso.Clientes;
using Papeleria.LogicaAplicacion.InterfacesCasosUso.Pedidos;
using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.InterfacesRepositorio;
using Papeleria.MVC.Models.PedidosModels;

namespace Papeleria.MVC.Controllers
{
    public class PedidosController : Controller
    {
        private static IRepositorioPedido _pedidos = new RepositorioPedidoEF(new PapeleriaContext());
        private static IRepositorioCliente _clientesRepo = new RepositorioClienteEF(new PapeleriaContext(), _pedidos);
        private static IRepositorioLineaPedido _lineaPedido = new RepositorioLineaPedidoEF(new PapeleriaContext());
        private static IRepositorioArticulo _articulos = new RepositorioArticuloEF(new PapeleriaContext());
        private static IAltaPedido _altaPedido;
        private static IBuscarClientes _buscarClientes;
        private static IGetArticulo _getArticulo = new BuscarArticulo(_articulos);
        private static IGetAllArticulos _getAllArticulos;
        private static PedidoDTO tempPedido;

        public PedidosController()
        {
            _buscarClientes = new BuscarClientes(_clientesRepo);
            _getAllArticulos = new GetAllArticulos(_articulos);
            _altaPedido = new AltaPedidos(_pedidos);
        }
        public IActionResult Index()
        {
            ViewBag.Clientes = _buscarClientes.GetAll();
            ViewBag.Articulos = _getAllArticulos.Ejecutar();
            tempPedido = null;
            Console.WriteLine(ViewBag.Articulos);
            Console.WriteLine(ViewBag.Clientes);
            return View();
        }

        [HttpGet]
        public IActionResult Crear()
        {
            if (HttpContext.Session.GetInt32("LogueadoID") != null)
            {
                ViewBag.Clientes = _buscarClientes.GetAll();
                ViewBag.Articulos = _getAllArticulos.Ejecutar();
                if (tempPedido != null)
                {
                    ViewBag.LineasPedido = tempPedido.LineasPedido;
                }
                var viewModel = new PedidoAltaModel
                {
                    LineasPedido = new List<LineaPedidoModel> { new LineaPedidoModel() } // Al menos una línea de pedido
                };
                return View(viewModel);
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(PedidoDTO pedidoAlta)
        {
            ViewBag.Clientes = _buscarClientes.GetAll();
            ViewBag.Articulos = _getAllArticulos.Ejecutar();
            if (pedidoAlta == null)
            {
                ViewBag.Error = "El pedido es invalido";
                return View();
            }
            if(pedidoAlta.FechaEntrega < DateTime.Now)
            {
                ViewBag.Error = "Fecha de entrega invalida";
                return View();
            }
            pedidoAlta.FechaPedido = DateTime.Now;
            try
            {
                if (tempPedido != null)
                {
                    ViewBag.LineasPedido = tempPedido.LineasPedido;
                }
                pedidoAlta.LineasPedido = tempPedido.LineasPedido;
                if((pedidoAlta.FechaEntrega.Subtract(pedidoAlta.FechaPedido)).Days < 5)
                {
                    _altaPedido.EjecutarExpress(pedidoAlta);
                } else
                {
                    _altaPedido.EjecutarComunes(pedidoAlta);
                }
                return RedirectToAction("Index", "Pedidos");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }

        [HttpPost]
        public ActionResult AddArticulo(PedidoDTO pedido, int ArticuloId, int Cantidad)
        {
            try
            {
                ArticuloDTO articulo = _getArticulo.GetByIdDTO(ArticuloId);
                LineaPedidoDTO altaLinea = new LineaPedidoDTO { idArticulo = articulo.Id, CodigoProveedor = articulo.CodigoProveedor, NombreArticulo = articulo.NombreArticulo, Descripcion = articulo.Descripcion, PrecioVP = articulo.PrecioVP, Stock = articulo.Stock, PrecioUnitario = articulo.PrecioVP, Cantidad = Cantidad, Subtotal = Cantidad * articulo.PrecioVP };
                if (tempPedido == null)
                {
                    tempPedido = new PedidoDTO { LineasPedido = new List<LineaPedidoDTO>() };
                }
                tempPedido.LineasPedido.Add(altaLinea);
                return RedirectToAction(nameof(Crear));

            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }

    }
}
