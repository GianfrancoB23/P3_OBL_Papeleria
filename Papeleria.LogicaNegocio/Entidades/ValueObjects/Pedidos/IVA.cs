using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Papeleria.LogicaNegocio.Entidades.ValueObjects.Pedidos
{
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

