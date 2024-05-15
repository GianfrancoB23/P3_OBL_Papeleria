using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Clientes
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        public long rut { get; set; }

        public string razonSocial { get; set; }

        public string Calle { get; init; }

        public int Numero { get; init; }

        public string Ciudad { get; init; }

        public int Distancia { get; init; }

    }
}
