using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Papeleria.LogicaNegocio.Entidades.ValueObjects
{
    public class NombreArticulo
    {
        public string nombre { get; set; }

        private Articulo articulo;

        private IValidable iValidable;

        public bool EsValido()
        {
            return null;
        }

    }

}

