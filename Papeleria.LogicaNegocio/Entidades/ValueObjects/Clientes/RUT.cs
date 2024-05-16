using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.Excepciones.Cliente.ClienteValueObjects.RUT;
using Papeleria.LogicaNegocio.InterfacesEntidades;
using System.ComponentModel.DataAnnotations.Schema;

namespace Papeleria.LogicaNegocio.Entidades.ValueObjects.Clientes
{
    [ComplexType]
    public record RUT : IValidable<RUT>, IEquatable<RUT>
    {
        public long Rut { get; init; }

        public RUT(long rut) 
        {
            if(rut == null)
            {
                throw new RutNuloException("RUT no puede estar vacio");
            }
            Rut = rut;
            esValido();
        }

        public void esValido()
        {
            if (Rut.ToString().Length != 12)
            {
                throw new RutNoValidoException("RUT Invalido, tiene que tener un largo de 12.");
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }


    }

}

