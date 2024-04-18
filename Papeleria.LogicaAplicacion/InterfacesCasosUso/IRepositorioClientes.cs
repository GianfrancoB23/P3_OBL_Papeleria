using Empresa.LogicaDeNegocio.Entidades;
using Empresa.LogicaDeNegocio.InterfacesRepositorios;
using IEmpresa.AccesoDatos.RepositorioMemoria;
using IEmpresa.AccesoDatos.RepostiorioEF;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Clientes;
using System.Collections.Generic;

namespace Empresa.LogicaDeNegocio.InterfacesRepositorios
{
	public interface IRepositorioClientes : IRepositorio<Cliente>
    {
<<<<<<< Updated upstream

		IEnumerable<Cliente> GetClientesPorPedido(int idPedido);

=======
		public IEnumerable<Cliente> GetClientes();
		public IEnumerable<Cliente> GetClientesPorPedido(int idPedido);
		public Cliente GetClientePorRUT(RUT rut);
		public Cliente GetClientePorRazon(RazonSocial rsocial);
		public Cliente GetClientePorDireccion(DireccionCliente direccionCliente);
		public Cliente GetCliente(int idCliente);
>>>>>>> Stashed changes
	}

}

