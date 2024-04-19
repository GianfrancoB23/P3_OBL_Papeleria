﻿using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.AccesoDatos.EF
{
    public class RepositorioExpressEF : IRepositorioExpress
    {
        private PapeleriaContext _db = new PapeleriaContext();
        public void Add(Express obj)
        {
            _db.Expresses.Add(obj);
            _db.SaveChanges();
        }

        public IEnumerable<Express> GetAll()
        {
            return _db.Expresses.ToList();
        }

        public Express GetById(int id)
        {
            Express? express = _db.Expresses.FirstOrDefault(pedido => pedido.Id == id);
            return express;
        }

        public IEnumerable<Express> GetObjectsByID(List<int> ids)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Express obj)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Express obj)
        {
            throw new NotImplementedException();
        }
    }
}
