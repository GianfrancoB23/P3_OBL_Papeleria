using Empresa.LogicaDeNegocio.Sistema de autenticación;
using Empresa.LogicaDeNegocio.Entidades;

namespace Empresa.LogicaDeNegocio.Sistema de autenticación
{
	public class Usuario
	{
		public Email email{ get; set; }

		public Nombre nombre{ get; set; }

		public Nombre apellido{ get; set; }

		public Contrasenia contrasenia{ get; set; }

		private IEntity iEntity;

		private IValidable iValidable;

		private Nombre nombre;

		private Email email;

		private Contrasenia contrasenia;

		private IEquatable_T_ iEquatable_T_;

		public bool EsValido()
		{
			return null;
		}

	}

}

