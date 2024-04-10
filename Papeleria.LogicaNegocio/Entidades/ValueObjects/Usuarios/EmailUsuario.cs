using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Papeleria.LogicaNegocio.Entidades.ValueObjects.Usuario
{
    public class EmailUsuario : IValidable<EmailUsuario>, IEquatable<EmailUsuario>
    {
        public string direccion { get; set; }

        public bool Equals(EmailUsuario? other)
        {
            throw new NotImplementedException();
        }

        public void esValido()
        {
            throw new NotImplementedException();
        }
    }
}
