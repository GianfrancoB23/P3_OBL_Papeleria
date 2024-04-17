using Empresa.LogicaDeNegocio.InterfacesRepositorios;
using System.Collections.Generic;

namespace Empresa.LogicaDeNegocio.InterfacesRepositorios
{
	public interface IRepositorio <T>
	{
		public void Add(T ojb);

        public void Remove(int id);

        public void Remove(T ojb);

        public void Update(int id, T obj);

        public IEnumerable<T> GetAll();

        public T GetById(int id);

	}

}

