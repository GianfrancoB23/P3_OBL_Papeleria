using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Usuarios;
using Papeleria.LogicaAplicacion.InterfacesCasosUso.Articulos;
using Papeleria.LogicaNegocio.Excepciones.Articulo;
using Papeleria.LogicaNegocio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.ImplementacionCasosUso.Articulos
{
    public class BorrarArticulo : IBorrarArticulo
    {
        private IRepositorioArticulo _repoArticulos;

        public BorrarArticulo(IRepositorioArticulo repo)
        {
            _repoArticulos = repo;
        }
        public void Ejecutar(int id, ArticuloBorrarDto articuloDel) 
        {
            if(articuloDel == null)
            {
                throw new ArticuloNuloException("Articulo no puede ser nulo");
            }
            try
            {
                var articulo = _repoArticulos.GetById(articuloDel.Id);
                _repoArticulos.Remove(articulo);
            } catch (Exception ex)
            {
                throw new ArticuloNoValidoException(ex.Message);
            }
        }
    }
}
