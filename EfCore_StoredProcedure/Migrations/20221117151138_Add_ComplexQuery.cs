using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreStoredProcedure.Migrations
{
    /// <inheritdoc />
    public partial class AddComplexQuery : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@" CREATE PROCEDURE [dbo].[KategoriVeUrunleri]
                                     AS
	                                 Select Kategoriler.KategoriAdi ,count(*) Adet
                                    from Kategoriler
                                    inner join Urunler on Kategoriler.Id = Urunler.KategoriId
                                    Group by Kategoriler.KategoriAdi
                                    ");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"drop procedure KategoriVeUrunleri");
        }
    }
}
