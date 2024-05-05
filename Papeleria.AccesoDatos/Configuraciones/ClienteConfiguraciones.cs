using Empresa.LogicaDeNegocio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.AccesoDatos.Configuraciones
{
    public class ClienteConfiguraciones : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            var razonSocialConverter = new ValueConverter<RazonSocial, string>
                (
                 rs => rs.RazonSoc,
                 rs => new RazonSocial(rs)
                );
            builder.Property(e => e.razonSocial).HasConversion(razonSocialConverter);
            builder.HasIndex(e => e.razonSocial);
        }
    }
}
