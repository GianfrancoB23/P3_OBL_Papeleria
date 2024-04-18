using Papeleria.LogicaNegocio.Entidades.ValueObjects.Pedidos;
using System;

namespace Empresa.LogicaDeNegocio.Entidades
{
    public class Comun : Pedido
    {
        public override void AgregarLineaPedido(Articulo articulo, int cantidad)
        {
            base.AgregarLineaPedido(articulo, cantidad);
        }

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

        public override DateTime FijarFechaPrometida()
        {
            throw new NotImplementedException();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }

}

