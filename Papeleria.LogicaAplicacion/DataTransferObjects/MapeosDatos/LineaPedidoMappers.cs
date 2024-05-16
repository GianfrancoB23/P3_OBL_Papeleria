using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.AccesoDatos.EF;
using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Articulos;
using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Pedidos;
using Papeleria.LogicaAplicacion.ImplementacionCasosUso.Articulos;
using Papeleria.LogicaAplicacion.InterfacesCasosUso.Articulos;
using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.Excepciones.Articulo;
using Papeleria.LogicaNegocio.Excepciones.Pedido;
using Papeleria.LogicaNegocio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.DataTransferObjects.MapeosDatos
{
    internal class LineaPedidoMappers
    {
        private static IRepositorioArticulo _repoArticulos = new RepositorioArticuloEF();
        private static IGetArticulo _getArticulo;
        public static LineaPedido FromDTO(LineaPedidoDTO dto)
        {
            _getArticulo = new BuscarArticulo(_repoArticulos);
            if (dto == null)
            {
                throw new PedidoNuloException("LinePedido nula");
            }
            Articulo articulo = _getArticulo.GetById(dto.idArticulo);
            return new LineaPedido(articulo, dto.Cantidad);
        }
        public static LineaPedido FromDTOUpdate(LineaPedidoDTO dto)
        {
            _getArticulo = new BuscarArticulo(_repoArticulos);
            if (dto == null)
            {
                throw new PedidoNuloException("LinePedido nula");
            }
            Articulo articulo = _getArticulo.GetById(dto.idArticulo);
            LineaPedido linea = new LineaPedido(articulo, dto.Cantidad);
            linea.Id = dto.id;
            return linea;
        }
        public static LineaPedidoDTO ToDto(LineaPedido linea)
        {
            if (linea == null) throw new PedidoNuloException();
            ArticuloDTO articulo = ArticulosMappers.ToDto(linea.Articulo);
            return new LineaPedidoDTO()
            {
                id = linea.Id,
                PedidoID = linea.pedido.Id,
                idArticulo = articulo.Id,
                CodigoProveedor = articulo.CodigoProveedor,
                NombreArticulo = articulo.NombreArticulo,
                Descripcion = articulo.Descripcion,
                PrecioVP = articulo.PrecioVP,
                Stock = articulo.Stock,
                Cantidad = linea.Cantidad,
                PrecioUnitario = articulo.PrecioVP,
                Subtotal = articulo.PrecioVP*linea.Cantidad
            };
        }

        public static IEnumerable<LineaPedidoDTO> FromLista(IEnumerable<LineaPedido> lineas)
        {
            if (lineas == null)
            {
                throw new PedidoNuloException("La lista de articulos no puede ser nula");
            }
            return lineas.Select(linea => ToDto(linea));
        }
    }
}
