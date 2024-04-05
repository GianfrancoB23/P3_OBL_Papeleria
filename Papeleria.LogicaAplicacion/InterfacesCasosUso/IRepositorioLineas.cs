using Empresa.LogicaDeNegocio.InterfacesRepositorios;
using IEmpresa.AccesoDatos.RepositorioMemoria;
using IEmpresa.AccesoDatos.RepostiorioEF;

namespace Empresa.LogicaDeNegocio.InterfacesRepositorios
{
	public interface IRepositorioLineas : IRepositorio_T_
	{
		private RepositorioLineas Memoria repositorioLineas Memoria;

		private RepositorioLineasEF repositorioLineasEF;

	}

}

