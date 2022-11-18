using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreBahis.Migrations
{
    /// <inheritdoc />
    public partial class initDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BahisKonulari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BahisAciklama = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Acikmi = table.Column<bool>(type: "bit", nullable: true),
                    KapanisSaati = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BahisKonulari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kasalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KasaAdi = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    ToplamBakiye = table.Column<double>(type: "float", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kasalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Oynayanlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TcNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Bakiye = table.Column<double>(type: "float", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oynayanlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Oyanananlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Guc = table.Column<double>(type: "float", nullable: false),
                    BahisKonusuId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oyanananlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Oyanananlar_BahisKonulari_BahisKonusuId",
                        column: x => x.BahisKonusuId,
                        principalTable: "BahisKonulari",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BahisCesitleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BahisKonusuId = table.Column<int>(type: "int", nullable: false),
                    OynananId = table.Column<int>(type: "int", nullable: false),
                    Oran = table.Column<double>(type: "float", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BahisCesitleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BahisCesitleri_BahisKonulari_BahisKonusuId",
                        column: x => x.BahisKonusuId,
                        principalTable: "BahisKonulari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BahisCesitleri_Oyanananlar_OynananId",
                        column: x => x.OynananId,
                        principalTable: "Oyanananlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BahisHareketleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BahisCesitId = table.Column<int>(type: "int", nullable: false),
                    OynayanId = table.Column<int>(type: "int", nullable: false),
                    OynananTutar = table.Column<double>(type: "float", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BahisHareketleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BahisHareketleri_BahisCesitleri_BahisCesitId",
                        column: x => x.BahisCesitId,
                        principalTable: "BahisCesitleri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BahisHareketleri_Oynayanlar_OynayanId",
                        column: x => x.OynayanId,
                        principalTable: "Oynayanlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KasaHareketleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KasaId = table.Column<int>(type: "int", nullable: false),
                    OynayanId = table.Column<int>(type: "int", nullable: false),
                    HareketTipi = table.Column<byte>(type: "tinyint", nullable: false),
                    Tutar = table.Column<double>(type: "float", nullable: false),
                    BahisCesitId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KasaHareketleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KasaHareketleri_BahisCesitleri_BahisCesitId",
                        column: x => x.BahisCesitId,
                        principalTable: "BahisCesitleri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KasaHareketleri_Kasalar_KasaId",
                        column: x => x.KasaId,
                        principalTable: "Kasalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KasaHareketleri_Oynayanlar_OynayanId",
                        column: x => x.OynayanId,
                        principalTable: "Oynayanlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BahisCesitleri_BahisKonusuId",
                table: "BahisCesitleri",
                column: "BahisKonusuId");

            migrationBuilder.CreateIndex(
                name: "IX_BahisCesitleri_OynananId",
                table: "BahisCesitleri",
                column: "OynananId");

            migrationBuilder.CreateIndex(
                name: "IX_BahisHareketleri_BahisCesitId",
                table: "BahisHareketleri",
                column: "BahisCesitId");

            migrationBuilder.CreateIndex(
                name: "IX_BahisHareketleri_OynayanId",
                table: "BahisHareketleri",
                column: "OynayanId");

            migrationBuilder.CreateIndex(
                name: "IX_KasaHareketleri_BahisCesitId",
                table: "KasaHareketleri",
                column: "BahisCesitId");

            migrationBuilder.CreateIndex(
                name: "IX_KasaHareketleri_KasaId",
                table: "KasaHareketleri",
                column: "KasaId");

            migrationBuilder.CreateIndex(
                name: "IX_KasaHareketleri_OynayanId",
                table: "KasaHareketleri",
                column: "OynayanId");

            migrationBuilder.CreateIndex(
                name: "IX_Kasalar_KasaAdi",
                table: "Kasalar",
                column: "KasaAdi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Oyanananlar_BahisKonusuId",
                table: "Oyanananlar",
                column: "BahisKonusuId");

            migrationBuilder.CreateIndex(
                name: "IX_Oynayanlar_TcNo",
                table: "Oynayanlar",
                column: "TcNo",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BahisHareketleri");

            migrationBuilder.DropTable(
                name: "KasaHareketleri");

            migrationBuilder.DropTable(
                name: "BahisCesitleri");

            migrationBuilder.DropTable(
                name: "Kasalar");

            migrationBuilder.DropTable(
                name: "Oynayanlar");

            migrationBuilder.DropTable(
                name: "Oyanananlar");

            migrationBuilder.DropTable(
                name: "BahisKonulari");
        }
    }
}
