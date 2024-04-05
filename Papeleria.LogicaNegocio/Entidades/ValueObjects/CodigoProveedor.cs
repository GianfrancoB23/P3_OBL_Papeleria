using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Papeleria.LogicaNegocio.Entidades.ValueObjects
{
    public class CodigoProveedor
    {
        public long codigo { get; set; }

        private Articulo articulo;

        private IValidable iValidable;

        private IEquatable_T_ iEquatable_T_;

        public bool EsValido()
        {
            return null;
        }

    }

}

