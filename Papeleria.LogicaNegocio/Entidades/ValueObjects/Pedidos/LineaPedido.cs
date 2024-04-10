using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Papeleria.LogicaNegocio.Entidades.ValueObjects.Pedidos
{
    public class LineaPedido : IValidable<LineaPedido>, IEquatable<LineaPedido>
    {
        public Articulo articulo { get; set; }

        public int cantidad { get; set; }

        public double precioUnitarioVigente { get; set; }

        public bool Equals(LineaPedido? other)
        {
            throw new NotImplementedException();
        }

        public void esValido()
        {
            throw new NotImplementedException();
        }
    }

}

