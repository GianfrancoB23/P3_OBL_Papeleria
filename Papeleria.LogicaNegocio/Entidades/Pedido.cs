using System;
using System.Collections.Generic;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Pedidos;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Empresa.LogicaDeNegocio.Entidades
{
    public abstract class Pedido : IValidable<Pedido>, IEquatable<Pedido>, IEntity
	{
        public int Id { get; set; }
		public DateTime fechaPedido{ get; set; }

		public Cliente cliente{ get; set; }

		public List<LineaPedido> lineas{ get; set; }

		public double precioFinal{ get; set; }

		public double recargo{ get; set; }

        public DateTime entregaPrometida { get; set; }

		public IVA iva { get; set; }

        public Pedido()
        {
            
        }

        public Pedido(DateTime fechaPedido, Cliente cliente, List<LineaPedido> lineas, double precioFinal, double recargo, IVA iva)
        {
            this.fechaPedido = fechaPedido;
            this.cliente = cliente;
            this.lineas = lineas;
            this.precioFinal = precioFinal;
            this.recargo = recargo;
            this.iva = iva;
        }

        public virtual void CalcularYFijarPrecio(IVA iva)
		{

		}

		public virtual void CambiarFechaPrometida()
		{

		}

		public virtual double CalcularRecargoYFijar()
		{
			return 0;
		}

        public virtual void esValido()
        {
            throw new NotImplementedException();
        }

        public virtual bool Equals(Pedido? other)
        {
            throw new NotImplementedException();
        }

    }

}

