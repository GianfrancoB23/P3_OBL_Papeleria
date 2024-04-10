using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Papeleria.LogicaNegocio.Entidades.ValueObjects.Pedidos
{
    public class IVA : IValidable<IVA>
    {
        public double valor { get; set; }

        public void esValido()
        {
            throw new NotImplementedException();
        }

        public void FijarValor()
        {

        }

    }

}

