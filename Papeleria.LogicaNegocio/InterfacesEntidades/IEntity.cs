using Empresa.LogicaDeNegocio.Sistema de autenticación;
using Empresa.LogicaDeNegocio.Entidades;

namespace Empresa.LogicaDeNegocio.Entidades
{
	public interface IEntity
	{
		private Usuario usuario;

		private Cliente cliente;

		private Pedido pedido;

		private Linea linea;

		private Articulo articulo;

	}

}

