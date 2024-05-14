using Empresa.LogicaDeNegocio.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Papeleria.AccesoDatos.EF;
using Papeleria.LogicaAplicacion.ImplementacionCasosUso.Clientes;
using Papeleria.LogicaAplicacion.InterfacesCasosUso.Clientes;
using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.InterfacesRepositorio;
using Papeleria.MVC.Models.PedidosModels;

namespace Papeleria.MVC.Controllers
{
    public class PedidosController : Controller
    {
        private static IRepositorioPedido _pedidos = new RepositorioPedidoEF(new PapeleriaContext());
        private static IRepositorioCliente _clientesRepo = new RepositorioClienteEF(new PapeleriaContext(), _pedidos);
        private static IBuscarClientes _buscarClientes;

        public PedidosController()
        {
            _buscarClientes = new BuscarClientes(_clientesRepo);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var viewModel = new PedidoAltaModel
            {
                LineasPedido = new List<LineaPedidoModel> { new LineaPedidoModel() } // Al menos una línea de pedido
            };
            return View(viewModel);
        }

        //[HttpPost]
        //public async Task<IActionResult> Crear(PedidoAltaModel viewModel)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(viewModel);
        //    }

        //    var cliente = await _context.Clientes.FindAsync(viewModel.ClienteId);
        //    if (cliente == null)
        //    {
        //        ModelState.AddModelError(string.Empty, "El cliente especificado no existe");
        //        return View(viewModel);
        //    }

        //    var pedido = new Pedido
        //    {
        //        Cliente = cliente,
        //        FechaPedido = DateTime.Now,
        //        FechaEntrega = viewModel.FechaEntrega
        //    };

        //    foreach (var lineaViewModel in viewModel.LineasPedido)
        //    {
        //        var articulo = await _context.Articulos.FindAsync(lineaViewModel.ArticuloId);
        //        if (articulo == null)
        //        {
        //            ModelState.AddModelError(string.Empty, $"El artículo con ID {lineaViewModel.ArticuloId} no existe");
        //            return View(viewModel);
        //        }

        //        if (articulo.Stock < lineaViewModel.Cantidad)
        //        {
        //            ModelState.AddModelError(string.Empty, $"No hay suficiente stock para el artículo '{articulo.Nombre}'");
        //            return View(viewModel);
        //        }

        //        pedido.LineasPedido.Add(new LineaPedido
        //        {
        //            Articulo = articulo,
        //            Cantidad = lineaViewModel.Cantidad
        //        });
        //    }

        //    _context.Pedidos.Add(pedido);
        //    await _context.SaveChangesAsync();

        //    // Calcular el monto total con impuestos
        //    var montoTotal = pedido.LineasPedido.Sum(linea => linea.Cantidad * linea.Articulo.PrecioVP);
        //    // Suponiendo que IVA es una constante
        //    var montoTotalConImpuestos = montoTotal * (1 + Constantes.IVA);

        //    // Puedes redirigir a una vista de confirmación mostrando el monto total con impuestos
        //    return RedirectToAction("Confirmacion", new { montoTotal = montoTotalConImpuestos });
        //}
    }
}
