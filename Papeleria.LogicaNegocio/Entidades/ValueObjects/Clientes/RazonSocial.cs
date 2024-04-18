using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.Comun;
using Papeleria.LogicaNegocio.Excepciones.Cliente.ClienteValueObjects.RazonSocial;
using Papeleria.LogicaNegocio.InterfacesEntidades;
using System.ComponentModel.DataAnnotations.Schema;

namespace Papeleria.LogicaNegocio.Entidades.ValueObjects.Clientes
{
    [ComplexType]
    public record RazonSocial : IValidable<RazonSocial>
    {
        public string RazonSoc { get; init; }


        public RazonSocial(string razon)
        {
            RazonSoc = razon;
            esValido();
        }
        public RazonSocial()
        {
            
        }
        public void esValido()
        {
            if (RazonSoc == null) { throw new RazonSocialNuloException("Razón social no puede ser nula"); }
            if (RazonSoc.Length <= 1) { throw new RazonSocialNoValidoException("Razón social invalida"); }
        }
    }

}

