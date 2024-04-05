using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.Entidades.ValueObjects;

using Empresa.LogicaDeNegocio.Sistema de autenticación;
using Empresa.LogicaDeNegocio.Entidades;

namespace Papeleria.LogicaNegocio.InterfacesEntidades
{
    public interface IValidable
    {
        private Email email;

        private Usuario usuario;

        private Nombre nombre;

        private Contrasenia contrasenia;

        private RUT rUT;

        private RazonSocial razonSocial;

        private Cliente cliente;

        private Direccion direccion;

        private Pedido pedido;

        private Linea linea;

        private StockArticulo stockArticulo;

        private CodigoProveedor codigoProveedor;

        private NombreArticulo nombreArticulo;

        private DescripcionArticulo descripcionArticulo;

        private Articulo articulo;

    }

}

