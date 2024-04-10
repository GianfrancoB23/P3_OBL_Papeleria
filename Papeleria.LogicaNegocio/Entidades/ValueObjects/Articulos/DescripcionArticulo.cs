using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Papeleria.LogicaNegocio.Entidades.ValueObjects.Articulos
{
    public class DescripcionArticulo : IValidable<DescripcionArticulo>
    {
        public string descripcion { get; set; }

        public void esValido()
        {
            throw new NotImplementedException();
        }
    }

}

