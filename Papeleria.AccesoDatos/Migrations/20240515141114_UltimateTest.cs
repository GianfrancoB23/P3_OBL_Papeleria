using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Papeleria.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class UltimateTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articulos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrecioVP = table.Column<double>(type: "float", nullable: false),
                    CodigoProveedor_codigo = table.Column<long>(type: "bigint", nullable: false),
                    Descripcion_Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreArticulo_Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stock_cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    razonSocial = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    direccion_Calle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direccion_Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direccion_Distancia = table.Column<int>(type: "int", nullable: false),
                    direccion_Numero = table.Column<int>(type: "int", nullable: false),
                    rut_Rut = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contrasenia_Valor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email_Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreCompleto_Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreCompleto_Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fechaPedido = table.Column<DateTime>(type: "datetime2", nullable: false),
                    clienteId = table.Column<int>(type: "int", nullable: false),
                    recargo = table.Column<double>(type: "float", nullable: false),
                    entregaPrometida = table.Column<int>(type: "int", nullable: false),
                    precioFinal = table.Column<double>(type: "float", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    iva_valor = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedidos_Clientes_clienteId",
                        column: x => x.clienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LineasPedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticuloId = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    PrecioUnitarioVigente = table.Column<double>(type: "float", nullable: false),
                    PedidoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineasPedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LineasPedidos_Articulos_ArticuloId",
                        column: x => x.ArticuloId,
                        principalTable: "Articulos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LineasPedidos_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_razonSocial",
                table: "Clientes",
                column: "razonSocial");

            migrationBuilder.CreateIndex(
                name: "IX_LineasPedidos_ArticuloId",
                table: "LineasPedidos",
                column: "ArticuloId");

            migrationBuilder.CreateIndex(
                name: "IX_LineasPedidos_PedidoId",
                table: "LineasPedidos",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_clienteId",
                table: "Pedidos",
                column: "clienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_precioFinal",
                table: "Pedidos",
                column: "precioFinal");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LineasPedidos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Articulos");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
