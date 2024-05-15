using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Pedidos;
using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Usuarios;
using Papeleria.LogicaAplicacion.DataTransferObjects.MapeosDatos;
using Papeleria.LogicaAplicacion.InterfacesCasosUso.Pedidos;
using Papeleria.LogicaNegocio.Excepciones.Pedido;
using Papeleria.LogicaNegocio.Excepciones.Usuario;
using Papeleria.LogicaNegocio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.ImplementacionCasosUso.Pedidos
{
    public class GetAllPedidos : IGetAllPedidos
    {
        private IRepositorioPedido _repositorioPedido;
        public GetAllPedidos(IRepositorioPedido repo)
        {
            _repositorioPedido = repo;        
        }

        public IEnumerable<PedidoDTO> Ejecutar()
        {
            var pedidosOrigen = _repositorioPedido.GetAll();
            if (pedidosOrigen == null || pedidosOrigen.Count() == 0)
            {
                throw new PedidoNuloException("No hay autores registrados");
            }
            return PedidosMappers.FromLista(pedidosOrigen);
        }

    }
}
