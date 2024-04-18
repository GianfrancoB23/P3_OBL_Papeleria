using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.InterfacesEntidades;
using System.ComponentModel.DataAnnotations.Schema;

namespace Papeleria.LogicaNegocio.Entidades.ValueObjects.Pedidos
{
    [ComplexType]
    public record IVA : IValidable<IVA>
    {
        public double valor { get; init; }

        public void esValido()
        {
            throw new NotImplementedException();
        }

        public void FijarValor()
        {

        }

    }

}

