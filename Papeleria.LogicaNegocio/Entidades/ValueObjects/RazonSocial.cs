using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Papeleria.LogicaNegocio.Entidades.ValueObjects
{
    public class RazonSocial
    {
        public string razon { get; set; }

        private Cliente cliente;

        private IValidable iValidable;

        public bool EsValido()
        {
            return null;
        }

    }

}

