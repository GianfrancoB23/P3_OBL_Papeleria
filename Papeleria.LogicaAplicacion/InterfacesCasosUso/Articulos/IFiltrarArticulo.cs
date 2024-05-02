﻿using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Articulos;
using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.InterfacesCasosUso.Articulos
{
    public interface IFiltrarArticulo
    {
        IEnumerable<ArticuloListadosDto> GetArticuloPorCodigo(long codigoProveedor);
        IEnumerable<ArticuloListadosDto> GetArticulosPorNombre(string nombre);

    }
}
