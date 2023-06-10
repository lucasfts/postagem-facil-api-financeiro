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
                    { 2, 1m, "Entre 3kg e 5kg" },
                    { 3, 2m, "Entre 5kg e 10kg" }
                });

            migrationBuilder.InsertData(
                table: "TiposCaixa",
                columns: new[] { "Id", "CustoPostal", "Descricao" },
                values: new object[,]
                {
                    { 1, 1.5m, "20cm x 20cm x 20cm" },
                    { 2, 2m, "40cm x 40cm x 40cm" },
                    { 3, 2.5m, "60cm x 60cm x 60cm" }
                });

            migrationBuilder.InsertData(
                table: "Transportadoras",
                columns: new[] { "Id", "FatorPostal", "Nome" },
                values: new object[,]
                {
                    { 1, 1m, "Correios" },
                    { 2, 0.95m, "JadLog" },
                    { 3, 1.7m, "DHL" },
                    { 4, 1.5m, "Fedex" }
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
        }
    }
}
