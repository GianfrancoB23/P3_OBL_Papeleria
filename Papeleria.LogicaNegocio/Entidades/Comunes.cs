using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Pedidos;
using Papeleria.LogicaNegocio.Excepciones.Pedido;
using System;

namespace Empresa.LogicaDeNegocio.Entidades
{
    public class Comunes : Pedido
    {
        public Comunes(): base()
        {

        }
        public override void AgregarLineaPedido(Articulo articulo, int cantidad)
        {
            base.AgregarLineaPedido(articulo, cantidad);
        }

        public override double CalcularRecargoYFijar()
        {
            // Recargo del 5% si la distancia a la dirección de entrega supera los 100 km
            if (cliente.direccion.Distancia > 100)
            {
                return 0.05;
            }
            return 0;
        }

        public override double CalcularYFijarPrecio(IVA iva, LineaPedido linea)
        {
            double precioInicial = linea.PrecioUnitarioVigente * linea.Cantidad;
            double recargoDistancia = CalcularRecargoYFijar();
            this.precioFinal = (precioInicial * (1 + iva.valor)) * (1 + recargoDistancia);
            return precioFinal;
        }

        public override void CambiarEntregaPrometida(int dias)
        {
            if (dias < 7)
            {
                throw new PedidoNoValidoException("No puede haber entregas 'COMUN' menor a una semana.");
            }
            if (dias == null)
            {
                throw new PedidoNuloException("La cantidad de días no puede ser nula en un pedido COMUN.");
            }
            entregaPrometida = new TimeSpan(dias, 0, 0, 0);
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override bool Equals(Pedido? other)
        {
            return base.Equals(other);
        }

        public override void esValido()
        {
            base.esValido();
        }

        public override TimeSpan FijarEntregaPrometida(int dias)
        {
            if (dias < 7)
            {
                throw new PedidoNoValidoException("No puede haber entregas 'COMUN' menor a una semana.");
            }
            if (dias == null)
            {
                throw new PedidoNuloException("La cantidad de dias no puede ser nulo en un pedido COMUN.");
            }
            return new TimeSpan(dias, 0, 0, 0);
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }

}

