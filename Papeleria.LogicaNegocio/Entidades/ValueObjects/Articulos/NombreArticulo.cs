using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.Excepciones.Articulo;
using Papeleria.LogicaNegocio.Excepciones.Articulo.ArticulosValueObjects.NombreArticulo;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Papeleria.LogicaNegocio.Entidades.ValueObjects.Articulos
{
    public record NombreArticulo : IValidable<NombreArticulo>, IEquatable<NombreArticulo>
    {
        public string Nombre { get; init; }

        public NombreArticulo(string nombre)
        {
            Nombre = nombre;
            esValido();
        }

        public NombreArticulo()
        {
            
        }
        public void esValido()
        {
            if (Nombre == null || Nombre.Length<1) { 
                throw new NombreArticuloNuloException("El nombre del articulo no puede ser nulo o vacio.");
            }
            
        }
    }

}

