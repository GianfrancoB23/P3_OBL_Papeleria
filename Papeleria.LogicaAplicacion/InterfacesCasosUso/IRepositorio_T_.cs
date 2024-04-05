using Empresa.LogicaDeNegocio.InterfacesRepositorios;
using System.Collections.Generic;

namespace Empresa.LogicaDeNegocio.InterfacesRepositorios
{
	public interface IRepositorio_T_
	{
		void Add(T t);

		void Remove(int id);

		void Remove(T t);

		void Update(int id, Autor modificado);

		IEnumerable<T> GetAll();

		T GetById(int id);

	}

}

