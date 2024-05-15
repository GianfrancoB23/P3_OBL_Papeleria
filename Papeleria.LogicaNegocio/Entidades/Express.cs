using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Pedidos;
using Papeleria.LogicaNegocio.Excepciones.Pedido;
using System;

namespace Empresa.LogicaDeNegocio.Entidades
{
    public class Express : Pedido
    {
        public Express():base()
        {
            
        }
            
        public Express(Cliente cliente, int dias, IVA iva, List<LineaPedido> lista):base(cliente,dias,iva,lista)
        {
            this.fechaPedido = DateTime.Now;
            this.cliente = cliente;
            this.lineas = lista;
            this.recargo = CalcularRecargoYFijar();
            this.iva = iva;
            this.entregaPrometida = FijarEntregaPrometida(dias);
            this.precioFinal = CalcularYFijarPrecio(iva);
            this.entregado = false;
            this.anulado = false;
            esValido();
        }

        public override double CalcularRecargoYFijar()
        {
            this.recargo = 0.10;
            if (entregaPrometida == 0) {
                this.recargo = 0.15;
            }
            return recargo;
        }

        public override double CalcularYFijarPrecio(IVA iva)
        {
            this.iva = iva;
            double subtotal = 0;
            foreach(LineaPedido line in lineas)
            {
                subtotal += line.PrecioUnitarioVigente * line.Cantidad;
            }
            this.precioFinal = (subtotal * (1 + recargo)) * (1 + iva.valor);
            return precioFinal;
        }

        public override void AgregarLineaPedido(Articulo articulo, int cantidad)
        {
            base.AgregarLineaPedido(articulo, cantidad);
        }
        public override void SetearEntregado()
        {
            base.SetearEntregado();
        }
        public override void AnularPedido()
        {
            base.AnularPedido();
        }
        public override void AgregarLineaPedido(LineaPedido linea)
        {
            base.AgregarLineaPedido(linea);
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override void esValido()
        {
            base.esValido();
        }

        public override bool Equals(Pedido? other)
        {
            return base.Equals(other);
        }

        public override int FijarEntregaPrometida(int dias)
        {
            this.entregaPrometida = dias;
            return dias;
        }

        public override void CambiarEntregaPrometida(int dias)
        {
            entregaPrometida = dias;
        }
    }

}

