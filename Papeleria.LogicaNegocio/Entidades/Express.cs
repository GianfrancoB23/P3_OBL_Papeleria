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

        public Express(Cliente cliente, int dias, IVA iva, LineaPedido linea):base(cliente,dias,iva,linea)
        {
            this.fechaPedido = DateTime.Now;
            this.cliente = cliente;
            this.lineas = new List<LineaPedido>();
            AgregarLineaPedido(linea);
            this.recargo = CalcularRecargoYFijar();
            this.iva = iva;
            this.entregaPrometida = FijarEntregaPrometida(dias);
            this.precioFinal = CalcularYFijarPrecio(iva, linea);
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

        public override double CalcularYFijarPrecio(IVA iva, LineaPedido linea)
        {
            double precioInicial = linea.PrecioUnitarioVigente * linea.Cantidad;
            this.precioFinal = (precioInicial * (1+iva.valor)) * (1 + recargo);
            return precioFinal;
        }

        public override void AgregarLineaPedido(Articulo articulo, int cantidad)
        {
            base.AgregarLineaPedido(articulo, cantidad);
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
            if (dias < 0)
            {
                throw new PedidoNoValidoException("No puede haber dias negativos para la entrega");
            }
            //if (dias > 5 && !EntregaEnElDia || dias>5)
            if (dias > 5)
            {
                throw new PedidoNoValidoException("La entrega prometida no puede ser superior a 5 dias en pedidos express");
            }
            if (dias == 0) { 
                return 0;
            }
            if (dias == null)
            {
                throw new PedidoNuloException("La cantidad de dias no puede ser nulo si NO se entrega en el dia.");
            }
            return dias;
        }

        public override void CambiarEntregaPrometida(int dias)
        {
            if (dias<0) {
                throw new PedidoNoValidoException("No puede haber dias negativos para la entrega");
            }
            if (dias == null) {
                throw new PedidoNuloException("La cantidad de dias no puede ser nulo si NO se entrega en el dia.");
            }
            if (dias < 5)
            {
                throw new PedidoNoValidoException("La entrega prometida no puede ser superior a 5 dias en pedidos express");
            }
            entregaPrometida = dias;
        }
    }

}

