using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.AccesoDatos.EF;
using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Clientes;
using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Pedidos;
using Papeleria.LogicaAplicacion.ImplementacionCasosUso.Clientes;
using Papeleria.LogicaAplicacion.InterfacesCasosUso.Clientes;
using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Pedidos;
using Papeleria.LogicaNegocio.Excepciones.Pedido;
using Papeleria.LogicaNegocio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.DataTransferObjects.MapeosDatos
{
    public class PedidosMappers
    {
        private static IRepositorioPedido _pedidos = new RepositorioPedidoEF();
        private static IRepositorioCliente _clientesRepo = new RepositorioClienteEF(_pedidos);
        private static IBuscarClientes _buscarClientes = new BuscarClientes(_clientesRepo);
        public static Pedido FromExpress(PedidoDTO pedido)
        {
            if (pedido == null) throw new PedidoNuloException(nameof(pedido));
            List<LineaPedido> lineasFinal = new List<LineaPedido>();
            foreach (LineaPedidoDTO linea in pedido.LineasPedido)
            {
                LineaPedido l = LineaPedidoMappers.FromDTO(linea);
                lineasFinal.Add(l);
            }
            var pedidoFinal = new Express();
            pedidoFinal.Id = pedido.Id;
            Cliente cliente = _buscarClientes.GetById(pedido.ClienteID);
            pedidoFinal.cliente = cliente;
            pedidoFinal.lineas = lineasFinal;
            pedidoFinal.CalcularRecargoYFijar();
            pedidoFinal.FijarEntregaPrometida((pedido.FechaEntrega - pedido.FechaPedido).Days);
            pedidoFinal.CalcularYFijarPrecio(new IVA(pedido.iva));
            try
            {
                pedidoFinal.esValido();
            }
            catch (Exception ex)
            {
                throw new PedidoNuloException("Pedido invalido");
            }
            return pedidoFinal;
        }
        public static Pedido FromComunes(PedidoDTO pedido)
        {
            if (pedido == null) throw new PedidoNuloException(nameof(pedido));
            List<LineaPedido> lineasFinal = new List<LineaPedido>();
            foreach(LineaPedidoDTO linea in pedido.LineasPedido)
            {
                LineaPedido l = LineaPedidoMappers.FromDTO(linea);
                lineasFinal.Add(l);
            }
            var pedidoFinal = new Comunes();
            pedidoFinal.Id = pedido.Id;
            Cliente cliente = _buscarClientes.GetById(pedido.ClienteID);
            pedidoFinal.cliente = cliente;
            pedidoFinal.lineas = lineasFinal;
            pedidoFinal.CalcularRecargoYFijar();
            pedidoFinal.FijarEntregaPrometida((pedido.FechaEntrega - pedido.FechaPedido).Days);
            pedidoFinal.CalcularYFijarPrecio(new IVA(pedido.iva));
            try
            {
                pedidoFinal.esValido();
            }
            catch (Exception ex)
            {
                throw new PedidoNuloException("Pedido invalido");
            }
            return pedidoFinal;
        }
        public static PedidoDTO ToExpressDto(Express pedido)
        {
            if (pedido == null) throw new PedidoNuloException();
            return new PedidoDTO()
            {
                Id = pedido.Id,
                FechaPedido = pedido.fechaPedido,
                FechaEntrega = pedido.fechaPedido.AddDays(pedido.entregaPrometida),
                ClienteID = pedido.cliente.Id,
                LineasPedido = LineaPedidoMappers.FromLista(pedido.lineas).ToList(),
                recargo = pedido.recargo,
                iva = pedido.iva.valor,
                precioFinal = pedido.precioFinal,
                entregado = pedido.entregado,
                anulado = pedido.anulado
            };
        }
        public static PedidoDTO ToComunesDto(Comunes pedido)
        {
            if (pedido == null) throw new PedidoNuloException();
            return new PedidoDTO()
            {
                Id = pedido.Id,
                FechaPedido = pedido.fechaPedido,
                FechaEntrega = pedido.fechaPedido.AddDays(pedido.entregaPrometida),
                ClienteID = pedido.cliente.Id,
                LineasPedido = LineaPedidoMappers.FromLista(pedido.lineas).ToList(),
                recargo = pedido.recargo,
                iva = pedido.iva.valor,
                precioFinal = pedido.precioFinal,
                entregado = pedido.entregado,
                anulado = pedido.anulado
            };
        }
        public static PedidoDTO ToDto(Pedido pedido)
        {
            if (pedido == null) throw new PedidoNuloException();
            return new PedidoDTO()
            {
                Id = pedido.Id,
                FechaPedido = pedido.fechaPedido,
                FechaEntrega = pedido.fechaPedido.AddDays(pedido.entregaPrometida),
                ClienteID = pedido.cliente.Id,
                LineasPedido = LineaPedidoMappers.FromLista(pedido.lineas).ToList(),
                recargo = pedido.recargo,
                iva = pedido.iva.valor,
                precioFinal = pedido.precioFinal,
                entregado = pedido.entregado,
                anulado = pedido.anulado
            };
        }

        public static IEnumerable<PedidoDTO> FromLista(IEnumerable<Pedido> pedidos)
        {
            if (pedidos == null)
            {
                throw new PedidoNuloException("La lista de pedidos no puede ser nula");
            }
            return pedidos.Select(pedido => ToDto(pedido));
        }

        public static IEnumerable<PedidoDTO> FromListaExpress(IEnumerable<Express> pedidos)
        {
            if (pedidos == null)
            {
                throw new PedidoNuloException("La lista de pedidos no puede ser nula");
            }
            return pedidos.Select(pedido => ToExpressDto(pedido));
        }

        public static IEnumerable<PedidoDTO> FromListaComunes(IEnumerable<Comunes> pedidos)
        {
            if (pedidos == null)
            {
                throw new PedidoNuloException("La lista de pedidos no puede ser nula");
            }
            return pedidos.Select(pedido => ToComunesDto(pedido));
        }
    }
}
