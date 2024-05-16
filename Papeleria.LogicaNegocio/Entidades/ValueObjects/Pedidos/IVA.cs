using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.Excepciones.Pedido.PedidoValueObjects;
using Papeleria.LogicaNegocio.InterfacesEntidades;
using System.ComponentModel.DataAnnotations.Schema;

namespace Papeleria.LogicaNegocio.Entidades.ValueObjects.Pedidos
{
    [ComplexType]
    public record IVA : IValidable<IVA>
    {
        public double valor { get; init; }

        public IVA(double valor)
        {
            if (valor >= 1)
            {
               valor = valor / 100;
            }
            this.valor = valor;
            esValido();
        }
        public IVA() { }
        public void esValido()
        {
            if(valor < 0)
            {
                throw new IvaNoValidoException("Valor de IVA no puede ser inferior a 0");
            }
            if(valor == null) { throw new IvaNuloException("IVA no puede estar vacio"); }
        }

        public void FijarValor()
        {

        }

    }

}

