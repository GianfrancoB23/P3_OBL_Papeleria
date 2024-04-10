using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Papeleria.LogicaNegocio.Entidades.ValueObjects.Clientes
{
    public class RUT : IValidable<RUT>, IEquatable<RUT>
    {
        public long rut { get; set; }

        public void esValido()
        {
            throw new NotImplementedException();
        }

        public bool Equals(RUT? other)
        {
            throw new NotImplementedException();
        }
    }

}

