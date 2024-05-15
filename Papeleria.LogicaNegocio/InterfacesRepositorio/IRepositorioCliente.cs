using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.InterfacesRepositorio
{
    public interface IRepositorioCliente:IRepositorio<Cliente>
    {
        IEnumerable<Cliente> GetClientesPorPedido(int idPedido);
        public IEnumerable<Cliente> GetClientes();
        public Cliente GetById(int id);
        public Cliente GetClientePorRUT(long rut);
        public Cliente GetClientePorRazon(string rsocial);
        public Cliente GetClientePorDireccion(DireccionCliente direccionCliente);
        public IEnumerable<Cliente> GetClientesPedidoSupereMonto(double monto);
        public Cliente GetCliente(int idCliente);
    }
}
