using Empresa.LogicaDeNegocio.Entidades;
using Empresa.LogicaDeNegocio.InterfacesRepositorios;
using IEmpresa.AccesoDatos.RepositorioMemoria;
using IEmpresa.AccesoDatos.RepostiorioEF;
using System.Collections.Generic;

namespace Empresa.LogicaDeNegocio.InterfacesRepositorios
{
	public interface IRepositorioClientes : IRepositorio<Cliente>
    {
		private RepositorioClientes Memoria repositorioClientes Memoria;

		private RepositorioClientesEF repositorioClientesEF;

		IEnumerable<Cliente> GetClientesPorPedido(int idPedido);

	}

}

