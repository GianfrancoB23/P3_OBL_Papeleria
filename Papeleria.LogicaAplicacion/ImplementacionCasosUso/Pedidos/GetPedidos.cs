using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.AccesoDatos.EF;
using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Articulos;
using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Pedidos;
using Papeleria.LogicaAplicacion.DataTransferObjects.MapeosDatos;
using Papeleria.LogicaAplicacion.InterfacesCasosUso.Pedidos;
using Papeleria.LogicaNegocio.Excepciones.Cliente;
using Papeleria.LogicaNegocio.Excepciones.Pedido;
using Papeleria.LogicaNegocio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.ImplementacionCasosUso.Pedidos
{
    public class GetPedidos : IGetPedido
    {
        private static IRepositorioPedido _repoPedidos = new RepositorioPedidoEF(new PapeleriaContext());
        private static IRepositorioCliente _clientesRepo = new RepositorioClienteEF(new PapeleriaContext(), _repoPedidos);
        public GetPedidos(IRepositorioPedido repo)
        {
            _repoPedidos = repo;
        }
        public Pedido GetById(int id)
        {
            return _repoPedidos.GetById(id);
        }

        public PedidoDTO GetByIdDTO(int id)
        {
            var pedido = _repoPedidos.GetById(id);
            if (pedido == null)
            {
                throw new PedidoNuloException("Pedido no encontrado con el ID especificado");
            }
            var pedidoReturn = PedidosMappers.ToDto(pedido);
            return pedidoReturn;
        }

        public IEnumerable<PedidoDTO> GetPedidosPorFecha(DateTime date)
        {
            var pedidos = _repoPedidos.GetPedidosPorFecha(date);
            if (pedidos == null)
            {
                throw new PedidoNuloException("No se encontraron pedidos desde la fecha especificada");
            }
            var pedidoReturn = PedidosMappers.FromLista(pedidos);
            return pedidoReturn;
        }
    }
}
