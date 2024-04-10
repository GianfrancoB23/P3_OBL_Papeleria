using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Papeleria.LogicaNegocio.Entidades.ValueObjects.Usuario
{
    public class ContraseniaUsuario : IValidable<ContraseniaUsuario>
    {
        public string contrasenia { get; set; }

        public void esValido()
        {
            throw new NotImplementedException();
        }
    }

}

