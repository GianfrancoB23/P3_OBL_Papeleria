using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Papeleria.LogicaNegocio.Entidades.ValueObjects
{
    public class RUT
    {
        public long rut { get; set; }

        private Cliente cliente;

        private IValidable iValidable;

        private IEquatable_T_ iEquatable_T_;

        public bool EsValido()
        {
            return null;
        }

    }

}

