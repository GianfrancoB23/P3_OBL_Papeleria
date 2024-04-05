using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Papeleria.LogicaNegocio.Entidades.ValueObjects
{
    public class Direccion
    {
        public string calle { get; set; }

        public int numero { get; set; }

        public string ciudad { get; set; }

        public int distancia { get; set; }

        private IValidable iValidable;

        private Cliente cliente;

        public bool EsValido()
        {
            return null;
        }

        public void CalcularYFijarDistancia()
        {

        }

    }

}

