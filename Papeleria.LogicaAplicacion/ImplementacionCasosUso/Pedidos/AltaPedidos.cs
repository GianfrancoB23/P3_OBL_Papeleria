using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Pedidos;
using Papeleria.LogicaAplicacion.DataTransferObjects.MapeosDatos;
using Papeleria.LogicaAplicacion.InterfacesCasosUso.Pedidos;
using Papeleria.LogicaNegocio.Excepciones.Pedido;
using Papeleria.LogicaNegocio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.ImplementacionCasosUso.Pedidos
{
    public  class AltaPedidos : IAltaPedido
    {
        private IRepositorioPedido _repoPedidos;

        public AltaPedidos(IRepositorioPedido _repositorioPedidos)
        {
            _repoPedidos = _repositorioPedidos; 
        }

        public void EjecutarExpress(PedidoDTO dto)
        {
            if (dto == null) {
                throw new PedidoNoValidoException("");
            }
            Pedido pedido = PedidosMappers.FromExpress(dto);
            
            _repoPedidos.Add(pedido);
        }

        public void EjecutarComunes(PedidoDTO dto)
        {
            if (dto == null)
            {
                throw new PedidoNoValidoException("");
            }
            Pedido pedido = PedidosMappers.FromComunes(dto);
            _repoPedidos.Add(pedido);
        }
    }
}
