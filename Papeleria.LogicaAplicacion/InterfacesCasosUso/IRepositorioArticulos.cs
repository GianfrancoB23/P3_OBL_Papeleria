using Empresa.LogicaDeNegocio.Entidades;
using Empresa.LogicaDeNegocio.InterfacesRepositorios;
using Empresa.AccesoDatos.RepositorioMemoria;
using Empresa.AccesoDatos.RepostiorioEF;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Articulos;
using System.Collections.Generic;

namespace Empresa.LogicaDeNegocio.InterfacesRepositorios
{
	public interface IRepositorioArticulos : IRepositorio<Articulo>
	{
<<<<<<< Updated upstream

		IEnumerable<Articulo> GetArticulosOrdenadosAlfabeticamente();
=======
		public IEnumerable<Articulo> GetArticulosOrdenadosAlfabeticamente();
		public IEnumerable<Articulo> GetArticuloByCodigo(CodigoProveedorArticulos codigo);
		public IEnumerable<Articulo> GetAllArticulos();

>>>>>>> Stashed changes

	}

}

