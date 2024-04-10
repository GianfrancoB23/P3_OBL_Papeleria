using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Papeleria.LogicaNegocio.Entidades.ValueObjects.Articulos
{
    public class NombreArticulo : IValidable<NombreArticulo>, IEquatable<NombreArticulo>
    {
        public string nombre { get; set; }

        public bool Equals(NombreArticulo? other)
        {
            throw new NotImplementedException();
        }

        public void esValido()
        {
            throw new NotImplementedException();
        }
    }

}

