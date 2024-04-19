﻿using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Articulos;
using Papeleria.LogicaNegocio.Excepciones.Articulo;
using Papeleria.LogicaNegocio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.AccesoDatos.EF
{
    public class RepositorioArticuloEF : IRepositorioArticulo
    {
        private PapeleriaContext _db = new PapeleriaContext();
        public void Add(Articulo obj)
        {
            try
            {
                _db.Articulos.Add(obj);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new ArticuloNoValidoException(ex.Message);
            }
        }

        public IEnumerable<Articulo> GetAll()
        {
            return _db.Articulos.ToList();
        }

        public Articulo GetArticuloByCodigo(CodigoProveedorArticulos codigo)
        {
            Articulo? articulo = _db.Articulos.FirstOrDefault(art => art.CodigoProveedor.codigo == codigo.codigo);
            return articulo;
        }

        public IEnumerable<Articulo> GetArticulosOrdenadosAlfabeticamente()
        {
            throw new NotImplementedException();
        }

        public Articulo GetById(int id)
        {
            Articulo? articulo = _db.Articulos.FirstOrDefault(art => art.Id == id);
            return articulo;
        }

        public IEnumerable<Articulo> GetObjectsByID(List<int> ids)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Articulo obj)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Articulo obj)
        {
            throw new NotImplementedException();
        }
    }
}
