using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Pedidos;
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
            throw new NotImplementedException();
        }

        public override double CalcularYFijarPrecio(IVA iva, LineaPedido linea)
        {
            throw new NotImplementedException();
        }

        public override void CambiarEntregaPrometida(int dias)
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

        public override TimeSpan FijarEntregaPrometida(int dias)
        {
            throw new NotImplementedException();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }

}

