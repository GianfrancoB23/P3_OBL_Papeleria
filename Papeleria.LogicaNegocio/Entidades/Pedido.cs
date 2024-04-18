using System;
using System.Collections.Generic;
using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Pedidos;
using Papeleria.LogicaNegocio.Excepciones.Cliente;
using Papeleria.LogicaNegocio.Excepciones.Pedido;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Empresa.LogicaDeNegocio.Entidades
{
    public abstract class Pedido : IValidable<Pedido>, IEquatable<Pedido>, IEntity
	{
        public int Id { get; set; }
		public DateTime fechaPedido{ get; set; }

		public Cliente cliente{ get; set; }

		public ICollection<LineaPedido> lineas { get; set; }
		public double recargo{ get; set; }
		public IVA iva { get; set; }
        public TimeSpan entregaPrometida { get; set; }
		public double precioFinal{ get; set; }


        public Pedido()
        {
            this.fechaPedido = DateTime.Now;
            this.lineas = new List<LineaPedido>();
        }

        public Pedido(Cliente cliente, int dias, IVA iva)
        {
            this.fechaPedido = DateTime.Now;
            this.cliente = cliente;
            this.lineas = new List<LineaPedido>();
            this.recargo = CalcularRecargoYFijar();
            this.iva = iva;
            this.entregaPrometida = FijarEntregaPrometida(dias);
            this.precioFinal = CalcularYFijarPrecio(iva);
            esValido();
        }

        public abstract double CalcularYFijarPrecio(IVA iva);
        public abstract TimeSpan FijarEntregaPrometida(int dias);
        public abstract void CambiarEntregaPrometida(int dias);

        public abstract double CalcularRecargoYFijar();

        public virtual void AgregarLineaPedido(Articulo articulo, int cantidad) {
            try {
                LineaPedido pedido = new LineaPedido(articulo,cantidad);
                lineas.Add(pedido);
            }catch(Exception ex)
            {
                throw new PedidoNoValidoException(ex.Message);
            }
        }

        public virtual void esValido()
        {
            if (cliente == null) {
                throw new ClienteNuloException("El cliente no puede ser nulo.");
            }
        }

        public virtual bool Equals(Pedido? other)
        {
            if (other == null)
                throw new PedidoNuloException("Debe incluir el pedido a comparar");
            return this.Id == other.Id;
        }

    }

}

