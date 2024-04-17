using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.Excepciones.Cliente.ClienteValueObjects.RUT;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Papeleria.LogicaNegocio.Entidades.ValueObjects.Clientes
{
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
                throw new RutNoValidoException("RUT Invalido");
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

