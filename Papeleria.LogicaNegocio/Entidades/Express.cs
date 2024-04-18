using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Pedidos;
using System;

namespace Empresa.LogicaDeNegocio.Entidades
{
    public class Express : Pedido
    {
        public bool EntregaEnElDia { get; set; }
        public override double CalcularRecargoYFijar()
        {
            throw new NotImplementedException();
        }

        public override double CalcularYFijarPrecio(IVA iva)
        {
            throw new NotImplementedException();
        }

        public override DateTime CambiarFechaPrometida()
        {
            throw new NotImplementedException();
        }

        public override DateTime FijarFechaPrometida()
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
    }

}

