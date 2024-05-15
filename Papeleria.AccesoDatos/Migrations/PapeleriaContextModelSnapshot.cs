﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Papeleria.AccesoDatos.EF;

#nullable disable

namespace Papeleria.AccesoDatos.Migrations
{
    [DbContext(typeof(PapeleriaContext))]
    partial class PapeleriaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Empresa.LogicaDeNegocio.Entidades.Articulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("PrecioVP")
                        .HasColumnType("float");

                    b.ComplexProperty<Dictionary<string, object>>("CodigoProveedor", "Empresa.LogicaDeNegocio.Entidades.Articulo.CodigoProveedor#CodigoProveedorArticulos", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<long>("codigo")
                                .HasColumnType("bigint");
                        });

                    b.ComplexProperty<Dictionary<string, object>>("Descripcion", "Empresa.LogicaDeNegocio.Entidades.Articulo.Descripcion#DescripcionArticulo", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Descripcion")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");
                        });

                    b.ComplexProperty<Dictionary<string, object>>("NombreArticulo", "Empresa.LogicaDeNegocio.Entidades.Articulo.NombreArticulo#NombreArticulo", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Nombre")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");
                        });

                    b.ComplexProperty<Dictionary<string, object>>("Stock", "Empresa.LogicaDeNegocio.Entidades.Articulo.Stock#StockArticulo", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<int>("cantidad")
                                .HasColumnType("int");
                        });

                    b.HasKey("Id");

                    b.ToTable("Articulos");
                });

            modelBuilder.Entity("Empresa.LogicaDeNegocio.Entidades.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("razonSocial")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.ComplexProperty<Dictionary<string, object>>("direccion", "Empresa.LogicaDeNegocio.Entidades.Cliente.direccion#DireccionCliente", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Calle")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Ciudad")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("Distancia")
                                .HasColumnType("int");

                            b1.Property<int>("Numero")
                                .HasColumnType("int");
                        });

                    b.ComplexProperty<Dictionary<string, object>>("rut", "Empresa.LogicaDeNegocio.Entidades.Cliente.rut#RUT", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<long>("Rut")
                                .HasColumnType("bigint");
                        });

                    b.HasKey("Id");

                    b.HasIndex("razonSocial");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Empresa.LogicaDeNegocio.Entidades.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<int>("clienteId")
                        .HasColumnType("int");

                    b.Property<int>("entregaPrometida")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaPedido")
                        .HasColumnType("datetime2");

                    b.Property<double>("precioFinal")
                        .HasColumnType("float");

                    b.Property<double>("recargo")
                        .HasColumnType("float");

                    b.ComplexProperty<Dictionary<string, object>>("iva", "Empresa.LogicaDeNegocio.Entidades.Pedido.iva#IVA", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<double>("valor")
                                .HasColumnType("float");
                        });

                    b.HasKey("Id");

                    b.HasIndex("clienteId");

                    b.HasIndex("precioFinal");

                    b.ToTable("Pedidos");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Pedido");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Empresa.LogicaDeNegocio.Sistema.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.ComplexProperty<Dictionary<string, object>>("Contrasenia", "Empresa.LogicaDeNegocio.Sistema.Usuario.Contrasenia#ContraseniaUsuario", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Valor")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");
                        });

                    b.ComplexProperty<Dictionary<string, object>>("Email", "Empresa.LogicaDeNegocio.Sistema.Usuario.Email#EmailUsuario", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Direccion")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");
                        });

                    b.ComplexProperty<Dictionary<string, object>>("NombreCompleto", "Empresa.LogicaDeNegocio.Sistema.Usuario.NombreCompleto#NombreCompleto", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Apellido")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Nombre")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");
                        });

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Papeleria.LogicaNegocio.Entidades.LineaPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ArticuloId")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int?>("PedidoId")
                        .HasColumnType("int");

                    b.Property<double>("PrecioUnitarioVigente")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ArticuloId");

                    b.HasIndex("PedidoId");

                    b.ToTable("LineasPedidos");
                });

            modelBuilder.Entity("Empresa.LogicaDeNegocio.Entidades.Comunes", b =>
                {
                    b.HasBaseType("Empresa.LogicaDeNegocio.Entidades.Pedido");

                    b.HasDiscriminator().HasValue("Comunes");
                });

            modelBuilder.Entity("Empresa.LogicaDeNegocio.Entidades.Express", b =>
                {
                    b.HasBaseType("Empresa.LogicaDeNegocio.Entidades.Pedido");

                    b.HasDiscriminator().HasValue("Express");
                });

            modelBuilder.Entity("Empresa.LogicaDeNegocio.Entidades.Pedido", b =>
                {
                    b.HasOne("Empresa.LogicaDeNegocio.Entidades.Cliente", "cliente")
                        .WithMany("pedidos")
                        .HasForeignKey("clienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cliente");
                });

            modelBuilder.Entity("Papeleria.LogicaNegocio.Entidades.LineaPedido", b =>
                {
                    b.HasOne("Empresa.LogicaDeNegocio.Entidades.Articulo", "Articulo")
                        .WithMany()
                        .HasForeignKey("ArticuloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Empresa.LogicaDeNegocio.Entidades.Pedido", null)
                        .WithMany("lineas")
                        .HasForeignKey("PedidoId");

                    b.Navigation("Articulo");
                });

            modelBuilder.Entity("Empresa.LogicaDeNegocio.Entidades.Cliente", b =>
                {
                    b.Navigation("pedidos");
                });

            modelBuilder.Entity("Empresa.LogicaDeNegocio.Entidades.Pedido", b =>
                {
                    b.Navigation("lineas");
                });
#pragma warning restore 612, 618
        }
    }
}
