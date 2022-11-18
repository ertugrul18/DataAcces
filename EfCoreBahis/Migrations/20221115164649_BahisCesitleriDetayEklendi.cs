using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EfCoreBahis.Migrations
{
    /// <inheritdoc />
    public partial class BahisCesitleriDetayEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BahisCesitleri_Oyanananlar_OynananId",
                table: "BahisCesitleri");

            migrationBuilder.DropForeignKey(
                name: "FK_BahisHareketleri_BahisCesitleri_BahisCesitId",
                table: "BahisHareketleri");

            migrationBuilder.DropColumn(
                name: "Oran",
                table: "BahisCesitleri");

            migrationBuilder.RenameColumn(
                name: "BahisCesitId",
                table: "BahisHareketleri",
                newName: "BahisCesitDetayId");

            migrationBuilder.RenameIndex(
                name: "IX_BahisHareketleri_BahisCesitId",
                table: "BahisHareketleri",
                newName: "IX_BahisHareketleri_BahisCesitDetayId");

            migrationBuilder.AddColumn<string>(
                name: "AdSoyad",
                table: "Oynayanlar",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "OynananId",
                table: "BahisCesitleri",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "BahisCesitDetay",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BahisCesitId = table.Column<int>(type: "int", nullable: false),
                    OynananId = table.Column<int>(type: "int", nullable: false),
                    Oran = table.Column<double>(type: "float", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BahisCesitDetay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BahisCesitDetay_BahisCesitleri_BahisCesitId",
                        column: x => x.BahisCesitId,
                        principalTable: "BahisCesitleri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BahisCesitDetay_Oyanananlar_OynananId",
                        column: x => x.OynananId,
                        principalTable: "Oyanananlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BahisKonulari",
                columns: new[] { "Id", "Acikmi", "BahisAciklama", "CreateDate", "KapanisSaati", "UpdateDate" },
                values: new object[] { 1, true, "Derse Gec Kalma", new DateTime(2022, 11, 15, 19, 46, 48, 826, DateTimeKind.Local).AddTicks(2587), new DateTime(2022, 11, 16, 19, 46, 48, 826, DateTimeKind.Local).AddTicks(2590), null });

            migrationBuilder.InsertData(
                table: "Kasalar",
                columns: new[] { "Id", "CreateDate", "KasaAdi", "ToplamBakiye", "UpdateDate" },
                values: new object[] { 1, new DateTime(2022, 11, 15, 19, 46, 48, 826, DateTimeKind.Local).AddTicks(5856), "TL Kasasi", 100000.0, null });

            migrationBuilder.InsertData(
                table: "Oynayanlar",
                columns: new[] { "Id", "AdSoyad", "Bakiye", "CreateDate", "TcNo", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "Ali Yilmaz", 1000.0, new DateTime(2022, 11, 15, 19, 46, 48, 826, DateTimeKind.Local).AddTicks(9249), "123", null },
                    { 2, "Ayse Kaya", 1000.0, new DateTime(2022, 11, 15, 19, 46, 48, 826, DateTimeKind.Local).AddTicks(9254), "124", null },
                    { 3, "Hasan Mert", 1000.0, new DateTime(2022, 11, 15, 19, 46, 48, 826, DateTimeKind.Local).AddTicks(9256), "125", null },
                    { 4, "Fatma Tasdemir", 1000.0, new DateTime(2022, 11, 15, 19, 46, 48, 826, DateTimeKind.Local).AddTicks(9259), "126", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BahisCesitDetay_BahisCesitId",
                table: "BahisCesitDetay",
                column: "BahisCesitId");

            migrationBuilder.CreateIndex(
                name: "IX_BahisCesitDetay_OynananId",
                table: "BahisCesitDetay",
                column: "OynananId");

            migrationBuilder.AddForeignKey(
                name: "FK_BahisCesitleri_Oyanananlar_OynananId",
                table: "BahisCesitleri",
                column: "OynananId",
                principalTable: "Oyanananlar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BahisHareketleri_BahisCesitDetay_BahisCesitDetayId",
                table: "BahisHareketleri",
                column: "BahisCesitDetayId",
                principalTable: "BahisCesitDetay",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BahisCesitleri_Oyanananlar_OynananId",
                table: "BahisCesitleri");

            migrationBuilder.DropForeignKey(
                name: "FK_BahisHareketleri_BahisCesitDetay_BahisCesitDetayId",
                table: "BahisHareketleri");

            migrationBuilder.DropTable(
                name: "BahisCesitDetay");

            migrationBuilder.DeleteData(
                table: "BahisKonulari",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Kasalar",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Oynayanlar",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Oynayanlar",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Oynayanlar",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Oynayanlar",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "AdSoyad",
                table: "Oynayanlar");

            migrationBuilder.RenameColumn(
                name: "BahisCesitDetayId",
                table: "BahisHareketleri",
                newName: "BahisCesitId");

            migrationBuilder.RenameIndex(
                name: "IX_BahisHareketleri_BahisCesitDetayId",
                table: "BahisHareketleri",
                newName: "IX_BahisHareketleri_BahisCesitId");

            migrationBuilder.AlterColumn<int>(
                name: "OynananId",
                table: "BahisCesitleri",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Oran",
                table: "BahisCesitleri",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddForeignKey(
                name: "FK_BahisCesitleri_Oyanananlar_OynananId",
                table: "BahisCesitleri",
                column: "OynananId",
                principalTable: "Oyanananlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BahisHareketleri_BahisCesitleri_BahisCesitId",
                table: "BahisHareketleri",
                column: "BahisCesitId",
                principalTable: "BahisCesitleri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
