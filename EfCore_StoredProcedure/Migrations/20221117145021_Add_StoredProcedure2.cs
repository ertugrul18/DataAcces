using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreStoredProcedure.Migrations
{
    /// <inheritdoc />
    public partial class AddStoredProcedure2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@" CREATE PROCEDURE [dbo].[UrunleriGetir2]
                                     @name as varchar(50)   
                                     AS
	                                 SELECT * from Urunler Where UrunAdi=@name
                                    ");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"drop procedure UrunleriGetir2");
        }
    }
}
