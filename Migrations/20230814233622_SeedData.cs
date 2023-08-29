using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApiTutorial.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TbProdutos",
                columns: new[] { "id", "descricao", "nome", "preco" },
                values: new object[,]
                {
                    { 1, "Caneta Bic Azul 1.0", "Caneta Bic Azul", 4.5m },
                    { 2, "Caderno 10 Mat Tilibra", "Caderno 10 Mat", 14.6m },
                    { 3, "Borracha Mercur 50", "Borracha Mercur", 2.8m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TbProdutos",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TbProdutos",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TbProdutos",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
