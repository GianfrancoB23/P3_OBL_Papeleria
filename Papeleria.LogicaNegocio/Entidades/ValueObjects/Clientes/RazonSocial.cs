using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Papeleria.LogicaNegocio.Entidades.ValueObjects.Clientes
{
    public class RazonSocial : IValidable<RazonSocial>
    {
        public string razon { get; set; }

        public void esValido()
        {
            throw new NotImplementedException();
        }
    }

}

