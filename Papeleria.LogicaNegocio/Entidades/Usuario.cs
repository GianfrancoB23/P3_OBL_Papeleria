

using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Usuario;
using Papeleria.LogicaNegocio.Excepciones.Usuario;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Empresa.LogicaDeNegocio.Sistema
{
    public class Usuario : IValidable<Usuario>, IEquatable<Usuario>, IEntity
	{
        public int Id { get; set; }
        public EmailUsuario Email{ get; set; }

		public NombreCompleto NombreCompleto{ get; set; }
		public ContraseniaUsuario Contrasenia{ get; set; }

        public Usuario(string email, string nombre, string apellido, string contrasenia)
        {
            this.Email = new EmailUsuario(email);
            this.NombreCompleto = new NombreCompleto(nombre, apellido);
            this.Contrasenia = new ContraseniaUsuario(contrasenia);
            esValido();
        }
        public Usuario()
        {
            
        }
        public bool Equals(Usuario? other)
        {
            throw new NotImplementedException();
        }

        public void esValido()
        {
            esValido(this);
        }

        public void esValido(Usuario usuario)
        {
            if(Email == null) {
                throw new UsuarioNoValidoExcepcion("El email no puede ser nulo para crear el usuario.");
            }
            if(NombreCompleto == null) {
                throw new UsuarioNoValidoExcepcion("El nombre y apellido no puede ser nulo para crear el usuario.");
            }
            if(Contrasenia == null) {
                throw new UsuarioNoValidoExcepcion("La contraseña no puede ser nula para crear el usuario.");
            }
        }
        public void ModificarDatos(Usuario obj)
        {
            if (obj == null)
                throw new UsuarioNuloExcepcion("El usuario al que desea modificar los datos no puede ser nulo.");
            esValido(obj);
            this.NombreCompleto = new NombreCompleto(obj.NombreCompleto.Nombre, obj.NombreCompleto.Apellido);
            this.Contrasenia = new ContraseniaUsuario(obj.Contrasenia.Valor);
        }
    }

}

