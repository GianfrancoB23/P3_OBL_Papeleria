using Empresa.LogicaDeNegocio.Sistema;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Clientes;
using Papeleria.LogicaNegocio.Excepciones.Cliente.ClienteValueObjects.Direccion;
using Papeleria.LogicaNegocio.Excepciones.Cliente.ClienteValueObjects.RazonSocial;
using Papeleria.LogicaNegocio.Excepciones.Cliente.ClienteValueObjects.RUT;
using Papeleria.LogicaNegocio.InterfacesEntidades;
using System.Collections.Generic;

namespace Empresa.LogicaDeNegocio.Entidades
{
    public class Cliente: IValidable<Cliente>, IEquatable<Cliente>, IEntity
	{
        public int Id { get; set; }
        public RUT rut{ get; set; }

		public RazonSocial razonSocial{ get; set; }

		public DireccionCliente direccion{ get; set; }

		public List<Pedido> pedidos{ get; set; }

        public Cliente(long rut, string razonSocial, string calle, int numero, string ciudad)
        {
            this.rut = new RUT(rut);
            this.razonSocial = new RazonSocial(razonSocial);
            this.direccion = new DireccionCliente(calle, numero, ciudad);
           this.pedidos = new List<Pedido>();
            esValido();
        }

        public Cliente()
        {
            
        }

        public void esValido()
        {
            if (rut == null) {
                throw new RutNuloException("El RUT no puede ser nulo.");
            }
            if (razonSocial == null) {
                throw new RazonSocialNuloException("La razon social no puede ser nula.");
            }
            if (direccion == null)
            {
                throw new DireccionNuloException("La direccion no puede ser nula.");
            }


        }
        public void Update(Cliente obj)
        {
            esValido();
            rut = obj.rut;
            razonSocial = obj.razonSocial;
            direccion = obj.direccion;
        }

        public bool Equals(Cliente? other)
        {
            if (other == null) return false;
            return this.rut == other.rut;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            return this.Equals(obj as Cliente);

        }
    }

}

