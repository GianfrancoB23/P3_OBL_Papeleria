using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.AccesoDatos.Memoria
{
    public class RepositorioExpressMemoria : IRepositorioExpress
    {
        public void Add(Express obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Express> GetAll()
        {
            throw new NotImplementedException();
        }

        public Express GetById(int id)
        {
            throw new NotImplementedException();
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
