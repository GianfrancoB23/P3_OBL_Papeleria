using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Papeleria.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class RazonSocial_Index : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "razonSocial_RazonSoc",
                table: "Clientes");

            migrationBuilder.AddColumn<string>(
                name: "razonSocial",
                table: "Clientes",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_precioFinal",
                table: "Pedidos",
                column: "precioFinal");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_razonSocial",
                table: "Clientes",
                column: "razonSocial");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Pedidos_precioFinal",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_razonSocial",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "razonSocial",
                table: "Clientes");

            migrationBuilder.AddColumn<string>(
                name: "razonSocial_RazonSoc",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
