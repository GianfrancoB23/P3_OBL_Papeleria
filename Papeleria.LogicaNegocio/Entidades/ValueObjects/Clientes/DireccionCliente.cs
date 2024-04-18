using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.Excepciones.Cliente.ClienteValueObjects.Direccion;
using Papeleria.LogicaNegocio.InterfacesEntidades;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Papeleria.LogicaNegocio.Entidades.ValueObjects.Clientes
{
    [ComplexType]
    public record DireccionCliente : IValidable<DireccionCliente>    
    {
        public string Calle { get; init; }

        public int Numero { get; init; }

        public string Ciudad { get; init; }

        public int Distancia { get; init; }

        public DireccionCliente(string calle, int numero, string ciudad, int distancia)
        {
            if (Calle == null || Ciudad == null || numero == null) { throw new DireccionNuloException("Debe ingresar todos los campos para direccion"); }
            Calle = calle;
            Numero = numero;
            Ciudad = ciudad;
            Distancia = CalcularYFijarDistancia(distancia);

        }
        public DireccionCliente()
        {
            
        }

        public int CalcularYFijarDistancia(int distancia)
        {
            return 0;
        }

        public void esValido()
        {
            if(Calle == null || Ciudad == null) { throw new DireccionNuloException("Debe ingresar todos los campos para direccion"); }
            if(Numero <= 0) { throw new DireccionNoValidoException("El número debe ser 1 o mayor");  }
            if(!Calle.Any(c => char.IsDigit(c))) { 
                throw new DireccionNoValidoException("Nombre de la calle no puede contener números"); 
            }
            if(!Ciudad.Any(c => char.IsDigit(c))) { throw new DireccionNoValidoException("Ciudad no puede contener números"); }
        }
    }

}

