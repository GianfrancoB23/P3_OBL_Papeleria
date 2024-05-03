using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Articulos;
using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Usuarios;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Articulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.InterfacesCasosUso.Articulos
{
    public interface IGetArticulo
    {
        ArticuloListadosDto GetById(int id);
        ArticuloListadosDto GetArticuloPorCodigo(CodigoProveedorArticulos codigoProveedor);
        IEnumerable<ArticuloListadosDto> GetArticulosPorNombre(string nombre);
    }
}
