﻿using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Articulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.InterfacesRepositorio
{
    public interface IRepositorioArticulo:IRepositorio<Articulo>
    {
        public IEnumerable<Articulo> GetArticulosOrdenadosAlfabeticamente();
        public IEnumerable<Articulo> GetArticuloByCodigo(CodigoProveedorArticulos codigo);
        public IEnumerable<Articulo> GetAllArticulos();
    }
}
