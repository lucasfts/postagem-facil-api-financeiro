using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PostagemFacil.Financeiro.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PesosLimite",
                columns: new[] { "Id", "CustoPostal", "Descricao" },
                values: new object[,]
                {
                    { 1, 0.5m, "Até 3kg" },
                    { 2, 1m, "Entre 3kg e 10kg" },
                    { 3, 2m, "Entre 10kg e 20kg" }
                });

            migrationBuilder.InsertData(
                table: "TiposCaixa",
                columns: new[] { "Id", "CustoPostal", "Descricao" },
                values: new object[,]
                {
                    { 1, 1.5m, "30cm x 30cm x 30cm" },
                    { 2, 2m, "60cm x 60cm x 60cm" },
                    { 3, 2.5m, "90cm x 90cm x 90cm" },
                    { 4, 3m, "120cm x 120cm x 120cm" }
                });

            migrationBuilder.InsertData(
                table: "Transportadoras",
                columns: new[] { "Id", "FatorPostal", "Nome" },
                values: new object[,]
                {
                    { 1, 1m, "Correios" },
                    { 2, 0.95m, "JadLog" },
                    { 3, 1.7m, "DHL" },
                    { 4, 2m, "UPS" },
                    { 5, 1.8m, "Fedex" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PesosLimite",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PesosLimite",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PesosLimite",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TiposCaixa",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TiposCaixa",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TiposCaixa",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TiposCaixa",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Transportadoras",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Transportadoras",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Transportadoras",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Transportadoras",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Transportadoras",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
