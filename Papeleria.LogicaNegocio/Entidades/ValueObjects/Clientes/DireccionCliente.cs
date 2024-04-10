using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Papeleria.LogicaNegocio.Entidades.ValueObjects.Clientes
{
    public class DireccionCliente : IValidable<DireccionCliente>    
    {
        public string calle { get; set; }

        public int numero { get; set; }

        public string ciudad { get; set; }

        public int distancia { get; set; }

        public void CalcularYFijarDistancia()
        {

        }

        public void esValido()
        {
            throw new NotImplementedException();
        }
    }

}

