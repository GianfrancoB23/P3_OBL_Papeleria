﻿using Empresa.LogicaDeNegocio.Entidades;
using Empresa.LogicaDeNegocio.Sistema;
using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Clientes;
using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Usuarios;
using Papeleria.LogicaAplicacion.DataTransferObjects.MapeosDatos;
using Papeleria.LogicaAplicacion.InterfacesCasosUso.Clientes;
using Papeleria.LogicaAplicacion.InterfacesCasosUso.Usuarios;
using Papeleria.LogicaNegocio.Excepciones.Cliente;
using Papeleria.LogicaNegocio.Excepciones.Usuario;
using Papeleria.LogicaNegocio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.ImplementacionCasosUso.Clientes
{
    public class AltaClientes : IAltaCliente
    {
        private IRepositorioCliente _repoClientes;

        public AltaClientes(IRepositorioCliente repo)
        {
            _repoClientes = repo;
        }

        public void Ejecutar(ClienteDTO dto)
        {
            if (dto == null)
                throw new ClienteNuloException("Nulo");

            Cliente cliente= ClientesMappers.FromDto(dto);
            _repoClientes.Add(cliente);
        }
    }
}
