using Empresa.LogicaDeNegocio.Entidades;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
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
            if (calle == null || ciudad == null || numero == null) { throw new DireccionNuloException("Debe ingresar todos los campos para direccion"); }
            Calle = calle;
            Numero = numero;
            Ciudad = ciudad;
            //Distancia = CalcularYFijarDistancia();
            Distancia = distancia;
            esValido();
        }
        public DireccionCliente()
        {
            
        }

        //public int CalcularYFijarDistancia()
        //{
        //    return 20;
        //}

        public void esValido()
        {
            if(Calle == null || Ciudad == null) { throw new DireccionNuloException("Debe ingresar todos los campos para direccion"); }
            if(Numero <= 0) { throw new DireccionNoValidoException("El número debe ser 1 o mayor");  }
            if(Ciudad.Any(char.IsDigit)) { throw new DireccionNoValidoException("Ciudad no puede contener números"); }
            if (Distancia < 0) { throw new DireccionNoValidoException("La distancia no puede ser menor a 0km"); }
        }
    }

}

