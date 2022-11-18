using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreStoredProcedure.Migrations
{
    /// <inheritdoc />
    public partial class AddComplexQuery2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kategoriVeUrunler",
                columns: table => new
                {
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "kategoriVeUrunler");
        }
    }
}
