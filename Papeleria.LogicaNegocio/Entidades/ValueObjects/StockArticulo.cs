using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Papeleria.LogicaNegocio.Entidades.ValueObjects
{
    public class StockArticulo
    {
        public Articulo articulo { get; set; }

        public int cantidad { get; set; }

        private Articulo articulo;

        private IValidable iValidable;

        private Articulo articulo;

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

        public bool EsValido()
        {
            return null;
        }

    }

}

