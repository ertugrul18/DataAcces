using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreSinema.Migrations
{
    /// <inheritdoc />
    public partial class NullableProp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gosterimler_Filmler_FilmId",
                table: "Gosterimler");

            migrationBuilder.DropForeignKey(
                name: "FK_Gosterimler_Haftalar_HaftaId",
                table: "Gosterimler");

            migrationBuilder.DropForeignKey(
                name: "FK_Gosterimler_Salonlar_SalonId",
                table: "Gosterimler");

            migrationBuilder.DropForeignKey(
                name: "FK_Gosterimler_Seanslar_SeansId",
                table: "Gosterimler");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Seanslar",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("122891d8-ea49-4543-b3cc-c97cb3c509fc"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("f00896a2-49fe-4c7a-bfcb-2daffb3b79d8"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Salonlar",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("3e4bfac8-8966-426c-9dc5-6d0eae70b151"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("3a2d8dd3-b516-4bcf-9e51-7f7f56707a0c"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Kategoriler",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("83103158-ce85-40e2-8cff-a55a83ecef70"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("889d1fb1-f9e2-4e2b-a78c-fd7628d2011c"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Haftalar",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("6ef82dde-a1a7-45de-84fd-15f75861d378"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("992927f6-24ba-48ab-8efc-7349e54d031a"));

            migrationBuilder.AlterColumn<Guid>(
                name: "SeansId",
                table: "Gosterimler",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "SalonId",
                table: "Gosterimler",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "HaftaId",
                table: "Gosterimler",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "FilmId",
                table: "Gosterimler",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Gosterimler",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("34bee920-7dd6-4716-99ad-2729efad2a22"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("070891fb-8d8b-45fc-9b13-48ae980c06da"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Filmler",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("08624742-225c-4f55-8e0a-bc243597c10b"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("7f1874ed-ba42-4ef8-9699-82f4e05458c3"));

            migrationBuilder.AddForeignKey(
                name: "FK_Gosterimler_Filmler_FilmId",
                table: "Gosterimler",
                column: "FilmId",
                principalTable: "Filmler",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Gosterimler_Haftalar_HaftaId",
                table: "Gosterimler",
                column: "HaftaId",
                principalTable: "Haftalar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Gosterimler_Salonlar_SalonId",
                table: "Gosterimler",
                column: "SalonId",
                principalTable: "Salonlar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Gosterimler_Seanslar_SeansId",
                table: "Gosterimler",
                column: "SeansId",
                principalTable: "Seanslar",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gosterimler_Filmler_FilmId",
                table: "Gosterimler");

            migrationBuilder.DropForeignKey(
                name: "FK_Gosterimler_Haftalar_HaftaId",
                table: "Gosterimler");

            migrationBuilder.DropForeignKey(
                name: "FK_Gosterimler_Salonlar_SalonId",
                table: "Gosterimler");

            migrationBuilder.DropForeignKey(
                name: "FK_Gosterimler_Seanslar_SeansId",
                table: "Gosterimler");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Seanslar",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("f00896a2-49fe-4c7a-bfcb-2daffb3b79d8"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("122891d8-ea49-4543-b3cc-c97cb3c509fc"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Salonlar",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("3a2d8dd3-b516-4bcf-9e51-7f7f56707a0c"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("3e4bfac8-8966-426c-9dc5-6d0eae70b151"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Kategoriler",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("889d1fb1-f9e2-4e2b-a78c-fd7628d2011c"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("83103158-ce85-40e2-8cff-a55a83ecef70"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Haftalar",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("992927f6-24ba-48ab-8efc-7349e54d031a"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("6ef82dde-a1a7-45de-84fd-15f75861d378"));

            migrationBuilder.AlterColumn<Guid>(
                name: "SeansId",
                table: "Gosterimler",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "SalonId",
                table: "Gosterimler",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "HaftaId",
                table: "Gosterimler",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "FilmId",
                table: "Gosterimler",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Gosterimler",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("070891fb-8d8b-45fc-9b13-48ae980c06da"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("34bee920-7dd6-4716-99ad-2729efad2a22"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Filmler",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("7f1874ed-ba42-4ef8-9699-82f4e05458c3"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("08624742-225c-4f55-8e0a-bc243597c10b"));

            migrationBuilder.AddForeignKey(
                name: "FK_Gosterimler_Filmler_FilmId",
                table: "Gosterimler",
                column: "FilmId",
                principalTable: "Filmler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gosterimler_Haftalar_HaftaId",
                table: "Gosterimler",
                column: "HaftaId",
                principalTable: "Haftalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gosterimler_Salonlar_SalonId",
                table: "Gosterimler",
                column: "SalonId",
                principalTable: "Salonlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gosterimler_Seanslar_SeansId",
                table: "Gosterimler",
                column: "SeansId",
                principalTable: "Seanslar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
