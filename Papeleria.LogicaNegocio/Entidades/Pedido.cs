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
        public DateTime fechaPedido { get; set; }

        public Cliente cliente { get; set; }

        public List<LineaPedido> lineas { get; set; }
        public double recargo { get; set; }
        public IVA iva { get; set; }
        public int entregaPrometida { get; set; }
        public double precioFinal { get; set; }
        public bool entregado { get; set; }
        public bool anulado { get; set; }


        public Pedido()
        {
            this.fechaPedido = DateTime.Now;
            this.lineas = new List<LineaPedido>();
            this.entregado = false;
            this.anulado = false;
        }

        public Pedido(Cliente cliente, int dias, IVA iva, List<LineaPedido> lista)
        {
            this.fechaPedido = DateTime.Now;
            this.cliente = cliente;
            this.lineas = lista;
            this.recargo = CalcularRecargoYFijar();
            this.iva = iva;
            this.entregaPrometida = FijarEntregaPrometida(dias);
            this.precioFinal = CalcularYFijarPrecio(iva);
            esValido();
        }

        public abstract double CalcularYFijarPrecio(IVA iva);
        public abstract int FijarEntregaPrometida(int dias);
        public abstract void CambiarEntregaPrometida(int dias);

        public abstract double CalcularRecargoYFijar();

        public virtual void SetearEntregado()
        {
            if (this.anulado)
            {
                throw new Exception("No se puede entregar un pedido que haya sido anulado"); ;
            }
            else
            {
                this.entregado = true;

            }
        }

        public virtual void AnularPedido()
        {
            if (this.entregado)
            {
                throw new Exception("No se puede anular un pedido ya entregado");
            }
            else
            {
                this.anulado = true;
            }
        }

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
            /*if (cliente == null)
            {
                throw new ClienteNuloException("El cliente no puede ser nulo.");
            }*/
            /*if(fechaPedido < DateTime.Now) { throw new PedidoNuloException("La fecha de pedido no puede ser inferior a la actual"); }*/
            if(entregaPrometida < 0) { throw new PedidoNuloException("La fecha de entrega no puede ser anterior a la fecha del pedido"); }
        }

        public virtual bool Equals(Pedido? other)
        {
            if (other == null)
                throw new PedidoNuloException("Debe incluir el pedido a comparar");
            return this.Id == other.Id;
        }

    }

}

