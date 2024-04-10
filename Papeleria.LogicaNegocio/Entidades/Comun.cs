using Papeleria.LogicaNegocio.Entidades.ValueObjects.Pedidos;
using System;

namespace Empresa.LogicaDeNegocio.Entidades
{
    public class Comun : Pedido
    {
        public override double CalcularRecargoYFijar()
        {
            return base.CalcularRecargoYFijar();
        }

        public override void CalcularYFijarPrecio(IVA iva)
        {
            base.CalcularYFijarPrecio(iva);
        }

        public override void CambiarFechaPrometida()
        {
            base.CambiarFechaPrometida();
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
    }

}

