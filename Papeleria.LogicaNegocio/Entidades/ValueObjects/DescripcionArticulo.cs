using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Papeleria.LogicaNegocio.Entidades.ValueObjects
{
    public class DescripcionArticulo
    {
        public string descripcion { get; set; }

        private Articulo articulo;

        private IValidable iValidable;

        public bool EsValido()
        {
            return null;
        }

    }

}

