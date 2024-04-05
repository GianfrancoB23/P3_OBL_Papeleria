using Empresa.LogicaDeNegocio.InterfacesRepositorios;
using IEmpresa.AccesoDatos.RepositorioMemoria;
using IEmpresa.AccesoDatos.RepostiorioEF;

namespace Empresa.LogicaDeNegocio.InterfacesRepositorios
{
	public interface IRepositorioUsuarios : IRepositorio_T_
	{
		private RepositorioUsuarios Memoria repositorioUsuarios Memoria;

		private RepositorioUsuariosEF repositorioUsuariosEF;

	}

}

