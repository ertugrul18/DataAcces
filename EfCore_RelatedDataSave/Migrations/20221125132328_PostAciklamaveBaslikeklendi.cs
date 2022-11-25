using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreRelatedDataSave.Migrations
{
    /// <inheritdoc />
    public partial class PostAciklamaveBaslikeklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "Postlar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Baslik",
                table: "Postlar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "Postlar");

            migrationBuilder.DropColumn(
                name: "Baslik",
                table: "Postlar");
        }
    }
}
