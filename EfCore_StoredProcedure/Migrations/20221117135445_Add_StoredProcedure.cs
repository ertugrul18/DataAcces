using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreStoredProcedure.Migrations
{
    /// <inheritdoc />
    public partial class AddStoredProcedure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@" CREATE PROCEDURE [dbo].[UrunleriGetir]
                                     AS
	                                 SELECT * from Urunler
                                    ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"drop procedure UrunleriGetir");
        }
    }
}
