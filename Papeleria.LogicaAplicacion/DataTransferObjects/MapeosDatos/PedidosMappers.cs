using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Pedidos;
using Papeleria.LogicaNegocio.Excepciones.Pedido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.DataTransferObjects.MapeosDatos
{
    public class PedidosMappers
    {
        public static Pedido FromDto(PedidoDTO dto)
        {
            if (dto == null) throw new PedidoNuloException(nameof(dto));
            Pedido pedido = new Pedido();
            return pedido;
        }
        public static Pedido FromDtoUpdate(PedidoDTO dto)
        {
            if (dto == null) throw new PedidoNuloException(nameof(dto));
            var articulo = new Pedido(dto.CodigoProveedor, dto.NombrePedido, dto.Descripcion, dto.PrecioVP, dto.Stock);
            articulo.Id = dto.Id;
            return articulo;
        }
        public static PedidoDTO ToDto(Pedido articulo)
        {
            if (articulo == null) throw new PedidoNuloException();
            return new PedidoDTO()
            {
                Id = articulo.Id,
                CodigoProveedor = articulo.CodigoProveedor.codigo,
                NombrePedido = articulo.NombrePedido.Nombre,
                Descripcion = articulo.Descripcion.Descripcion,
                PrecioVP = articulo.PrecioVP,
                Stock = articulo.Stock.StockActual()
            };
        }

        public static IEnumerable<PedidoDTO> FromLista(IEnumerable<Pedido> articulos)
        {
            if (articulos == null)
            {
                throw new PedidoNuloException("La lista de articulos no puede ser nula");
            }
            return articulos.Select(articulo => ToDto(articulo));
        }
    }
}
