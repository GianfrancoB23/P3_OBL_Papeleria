using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.Excepciones.Usuario.UsuarioExcepcions.Email;
using Papeleria.LogicaNegocio.InterfacesEntidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Papeleria.LogicaNegocio.Entidades.ValueObjects.Usuario
{
    [ComplexType]
    public record EmailUsuario :IValidable<EmailUsuario>, IEquatable<EmailUsuario>
    {
        public string Direccion { get; init; }
        public EmailUsuario(string direccion) {
            if (direccion == null)
            {
                throw new ArgumentNullException(nameof(direccion), "No puede ser nulo");
            }
            esValido();
            direccion = direccion;
        }
        public void esValido(EmailUsuario emailUsuario)
        {
            if (emailUsuario == null) {
               throw new EmailNuloException("El email no puede ser nulo.");
            }
            if (emailUsuario.Direccion.Length < 6 || !emailUsuario.Direccion.Contains("@")) { 
                throw new EmailNoValidoException("Email no v�lido. Largo m�nimo 6 y debe incluir un arroba.");
            }
            if (emailUsuario.Direccion.IndexOf("@") == 0 || emailUsuario.Direccion.IndexOf("@") == emailUsuario.Direccion.Length-1) {
                throw new EmailNoValidoException("Email no v�lido. No puede contener @ en el principio o en el final.");
            }
        }

        public void esValido()
        {
            esValido(this);
        }
    }
}
