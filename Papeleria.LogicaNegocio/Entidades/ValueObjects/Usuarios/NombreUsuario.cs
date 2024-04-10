using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Papeleria.LogicaNegocio.Entidades.ValueObjects.Usuario
{
    public class NombreUsuario : IValidable<NombreUsuario>
    {
        public string nombre { get; set; }

        public void esValido()
        {
            throw new NotImplementedException();
        }
    }

}

