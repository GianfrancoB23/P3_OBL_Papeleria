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
        IEnumerable<Cliente> GetClientesPorPedido(int idPedido);
        public IEnumerable<Cliente> GetClientes();
        public Cliente GetClientePorRUT(RUT rut);
        public Cliente GetClientePorRazon(RazonSocial rsocial);
        public Cliente GetClientePorDireccion(DireccionCliente direccionCliente);
        public Cliente GetCliente(int idCliente);
    }
}
