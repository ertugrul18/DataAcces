using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EfCoreStoredProcedure.Migrations
{
    /// <inheritdoc />
    public partial class AddUrun : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "Id", "KategoriId", "UrunAdi" },
                values: new object[,]
                {
                    { 5, 2, "Gazoz" },
                    { 6, 2, "Sari Gazoz" },
                    { 7, 2, "KAra gazoz" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
