using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Clientes;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Pedidos;
using Papeleria.LogicaNegocio.Excepciones.Cliente;
using Papeleria.LogicaNegocio.Excepciones.Pedido;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Empresa.LogicaDeNegocio.Entidades
{
    [Index(nameof(precioFinal))]
    public abstract class Pedido : IValidable<Pedido>, IEquatable<Pedido>, IEntity
	{
        public int Id { get; set; }
		public DateTime fechaPedido{ get; set; }

		public Cliente cliente{ get; set; }

		public ICollection<LineaPedido> lineas { get; set; }
		public double recargo{ get; set; }
		public IVA iva { get; set; }
        public int entregaPrometida { get; set; }
		public double precioFinal{ get; set; }


        public Pedido()
        {
            this.fechaPedido = DateTime.Now;
            this.lineas = new List<LineaPedido>();
        }

        public Pedido(Cliente cliente, int dias, IVA iva, LineaPedido linea)
        {
            this.fechaPedido = DateTime.Now;
            this.cliente = cliente;
            this.lineas = new List<LineaPedido>();
            lineas.Add(linea);
            this.recargo = CalcularRecargoYFijar();
            this.iva = iva;
            this.entregaPrometida = FijarEntregaPrometida(dias);
            this.precioFinal = CalcularYFijarPrecio(iva, linea);
            esValido();
        }

        public abstract double CalcularYFijarPrecio(IVA iva, LineaPedido linea);
        public abstract int FijarEntregaPrometida(int dias);
        public abstract void CambiarEntregaPrometida(int dias);

        public abstract double CalcularRecargoYFijar();

        public virtual void AgregarLineaPedido(Articulo articulo, int cantidad)
        {
            try
            {
                LineaPedido pedido = new LineaPedido(articulo, cantidad);
                lineas.Add(pedido);
            }
            catch (Exception ex)
            {
                throw new PedidoNoValidoException(ex.Message);
            }
        }


        public virtual void AgregarLineaPedido(LineaPedido linea)
        {
            try
            {
                lineas.Add(linea);
            }
            catch (Exception ex)
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

