using Empresa.LogicaDeNegocio.InterfacesRepositorios;
using IEmpresa.AccesoDatos.RepositorioMemoria;
using IEmpresa.AccesoDatos.RepostiorioEF;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Pedidos;

namespace Empresa.LogicaDeNegocio.InterfacesRepositorios
{
	public interface IRepositorioLineas : IRepositorio<LineaPedido>
    {
		private RepositorioLineas Memoria repositorioLineas Memoria;

		private RepositorioLineasEF repositorioLineasEF;

	}

}

