

using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Usuario;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Empresa.LogicaDeNegocio.Sistema
{
    public class Usuario : IValidable<Usuario>, IEquatable<Usuario>, IEntity
	{
        public int Id { get; set; }
        public EmailUsuario email{ get; set; }

		public NombreUsuario nombre{ get; set; }

		public NombreUsuario apellido{ get; set; }

		public ContraseniaUsuario contrasenia{ get; set; }

        public bool Equals(Usuario? other)
        {
            throw new NotImplementedException();
        }

        public void esValido()
        {
            throw new NotImplementedException();
        }
    }

}

