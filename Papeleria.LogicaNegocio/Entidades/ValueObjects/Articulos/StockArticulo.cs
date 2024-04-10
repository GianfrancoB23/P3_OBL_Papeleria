using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Papeleria.LogicaNegocio.Entidades.ValueObjects.Articulos
{
    public class StockArticulo : IValidable<StockArticulo>
    {
        public Articulo articulo { get; set; }

        public int cantidad { get; set; }

        public int StockActual()
        {
            return 0;
        }

        public void RestarStock()
        {

        }

        public void SumarStock()
        {

        }

        public void esValido()
        {
            throw new NotImplementedException();
        }
    }

}

