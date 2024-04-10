using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.Entidades.ValueObjects;

namespace Papeleria.LogicaNegocio.InterfacesEntidades
{
    public interface IValidable<T> where T : class
    {
        void esValido();

    }

}

