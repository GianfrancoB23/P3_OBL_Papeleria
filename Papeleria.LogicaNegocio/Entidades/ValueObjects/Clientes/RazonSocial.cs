using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.Comun;
using Papeleria.LogicaNegocio.Excepciones.Cliente.ClienteValueObjects.RazonSocial;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Papeleria.LogicaNegocio.Entidades.ValueObjects.Clientes
{
    public record RazonSocial : IValidable<RazonSocial>
    {
        public string RazonSoc { get; init; }


        public RazonSocial(string razon)
        {
            RazonSoc = razon;
            esValido();
        }

        public void esValido()
        {
            if (RazonSoc == null) { throw new RazonSocialNuloException("Raz�n social no puede ser nula"); }
            if (RazonSoc.Length <= 1) { throw new RazonSocialNoValidoException("Raz�n social invalida"); }
        }
    }

}

