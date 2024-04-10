using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Papeleria.LogicaNegocio.Entidades.ValueObjects.Articulos
{
    public class CodigoProveedorArticulos : IValidable<CodigoProveedorArticulos>, IEquatable<CodigoProveedorArticulos>
    {
        public long codigo { get; set; }

        private Articulo articulo;

        public void esValido()
        {
            throw new NotImplementedException();
        }

        public bool Equals(CodigoProveedorArticulos? other)
        {
            throw new NotImplementedException();
        }
    }

}

