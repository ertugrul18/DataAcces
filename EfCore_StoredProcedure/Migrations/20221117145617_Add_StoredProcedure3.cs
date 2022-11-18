using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreStoredProcedure.Migrations
{
    /// <inheritdoc />
    public partial class AddStoredProcedure3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@" CREATE PROCEDURE [dbo].[UrunSayisi]
                                     AS
	                                 SELECT count(*) from Urunler
                                    ");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"drop procedure UrunSayisi");
        }
    }
}
