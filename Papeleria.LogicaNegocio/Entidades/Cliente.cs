using Papeleria.LogicaNegocio.Entidades.ValueObjects.Clientes;
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

		public List<Pedido> pedidos{ get; set; } = new List<Pedido>();

        public Cliente(RUT rut, RazonSocial razonSocial, DireccionCliente direccion, List<Pedido> pedidos)
        {
            this.rut = rut;
            this.razonSocial = razonSocial;
            this.direccion = direccion;
        }

        public Cliente()
        {
            
        }

        public void esValido()
        {
            throw new NotImplementedException();
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

