using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreSinema.Migrations
{
    /// <inheritdoc />
    public partial class newGuid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Seanslar",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("f00896a2-49fe-4c7a-bfcb-2daffb3b79d8"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Salonlar",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("3a2d8dd3-b516-4bcf-9e51-7f7f56707a0c"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Kategoriler",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("889d1fb1-f9e2-4e2b-a78c-fd7628d2011c"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Haftalar",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("992927f6-24ba-48ab-8efc-7349e54d031a"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Gosterimler",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("070891fb-8d8b-45fc-9b13-48ae980c06da"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Filmler",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("7f1874ed-ba42-4ef8-9699-82f4e05458c3"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Seanslar",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("f00896a2-49fe-4c7a-bfcb-2daffb3b79d8"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Salonlar",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("3a2d8dd3-b516-4bcf-9e51-7f7f56707a0c"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Kategoriler",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("889d1fb1-f9e2-4e2b-a78c-fd7628d2011c"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Haftalar",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("992927f6-24ba-48ab-8efc-7349e54d031a"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Gosterimler",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("070891fb-8d8b-45fc-9b13-48ae980c06da"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Filmler",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("7f1874ed-ba42-4ef8-9699-82f4e05458c3"));
        }
    }
}
