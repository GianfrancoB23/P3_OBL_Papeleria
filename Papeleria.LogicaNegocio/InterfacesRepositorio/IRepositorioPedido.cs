using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.InterfacesRepositorio
{
    public interface IRepositorioPedido:IRepositorio<Pedido>
    {
        public IEnumerable<Pedido> GetPedidosPorCliente(Cliente cliente);
        public IEnumerable<Pedido> GetPedidosPorRUT(RUT rut);
        public IEnumerable<Pedido> GetPedidosPorRazon(RazonSocial rsocial);
        public IEnumerable<Pedido> GetPedidosPorDireccion(DireccionCliente direccionPedido);
        public Pedido GetPedido(Pedido pedido);
        public IEnumerable<Pedido> GetPedidosQueSuperenMonto(double monto);
    }
}
