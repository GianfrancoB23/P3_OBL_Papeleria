using Empresa.LogicaDeNegocio.Sistema;
using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Usuario;
using Papeleria.LogicaAplicacion.DataTransferObjects.MapeosDatos;
using Papeleria.LogicaNegocio.Excepciones.Articulo;
using Papeleria.LogicaNegocio.Excepciones.Usuario;
using Papeleria.LogicaNegocio.InterfacesRepositorio;
using Empresa.LogicaDeNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Articulos;
using Papeleria.LogicaAplicacion.InterfacesCasosUso.Articulos;

namespace Papeleria.LogicaAplicacion.ImplementacionCasosUso.Articulos
{
    public class AltaArticulo : IAltaArticulo
    {
        private IRepositorioArticulo _repoArticulos;

        public AltaArticulo(IRepositorioArticulo repo)
        {
            _repoArticulos = repo;
        }

        public void Ejecutar(ArticuloAltaDto dto)
        {
            if (dto == null)
                throw new ArticuloNuloException("Nulo");

            Articulo articulo = ArticulosMappers.FromDto(dto);
            _repoArticulos.Add(articulo);
        }
    }
}
