using Empresa.LogicaDeNegocio.InterfacesRepositorios;
using IEmpresa.AccesoDatos.RepositorioMemoria;
using IEmpresa.AccesoDatos.RepostiorioEF;
using System.Collections.Generic;

namespace Empresa.LogicaDeNegocio.InterfacesRepositorios
{
	public interface IRepositorioArticulos : IRepositorio_T_
	{
		private RepositorioArticulos Memoria repositorioArticulos Memoria;

		private RepositorioArticulosEF repositorioArticulosEF;

		IEnumerable<Articulo> GetArticulosOrdenadosAlfabeticamente();

	}

}

