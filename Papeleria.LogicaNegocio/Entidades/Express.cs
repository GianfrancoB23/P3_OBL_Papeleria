using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Pedidos;
using Papeleria.LogicaNegocio.Excepciones.Pedido;
using System;

namespace Empresa.LogicaDeNegocio.Entidades
{
    public class Express : Pedido
    {
        public bool EntregaEnElDia { get; set; }
        public Express():base()
        {
            
        }

        public Express(Cliente cliente, int dias, IVA iva, bool entregaEnElDia):base(cliente,dias,iva)
        {
            EntregaEnElDia = entregaEnElDia;
        }

        public override double CalcularRecargoYFijar()
        {
            double recargo = 0.10;
            if (EntregaEnElDia) {
                recargo = 0.15;
            }
            return recargo;
        }

        public override double CalcularYFijarPrecio(IVA iva)
        {
            throw new NotImplementedException();
        }

        public override void AgregarLineaPedido(Articulo articulo, int cantidad)
        {
            base.AgregarLineaPedido(articulo, cantidad);
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

        public override TimeSpan FijarEntregaPrometida(int dias)
        {
            if (dias < 0)
            {
                throw new PedidoNoValidoException("No puede haber dias negativos para la entrega");
            }
            if (dias < 5 && !EntregaEnElDia || dias<5) {
                throw new PedidoNoValidoException("La entrega prometida no puede ser superior a 5 dias en pedidos express");
            }
            if (EntregaEnElDia) { 
                return TimeSpan.Zero;
            }
            if (dias == null && !EntregaEnElDia)
            {
                throw new PedidoNuloException("La cantidad de dias no puede ser nulo si NO se entrega en el dia.");
            }
            return new TimeSpan(dias, 0, 0, 0);
        }

        public override void CambiarEntregaPrometida(int dias)
        {
            if (dias<0) {
                throw new PedidoNoValidoException("No puede haber dias negativos para la entrega");
            }
            if (dias == null && !EntregaEnElDia) {
                throw new PedidoNuloException("La cantidad de dias no puede ser nulo si NO se entrega en el dia.");
            }
            if (dias < 5 && !EntregaEnElDia || dias < 5)
            {
                throw new PedidoNoValidoException("La entrega prometida no puede ser superior a 5 dias en pedidos express");
            }
            entregaPrometida = new TimeSpan(dias, 0, 0, 0);
        }
    }

}

