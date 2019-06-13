using Microsoft.EntityFrameworkCore.Migrations;

namespace MyPlace.Migrations
{
    public partial class SeedDatabse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO CATEGORIES (Name) VALUES ('Technology')");
            migrationBuilder.Sql("INSERT INTO CATEGORIES (Name) VALUES ('Science')");
            migrationBuilder.Sql("INSERT INTO CATEGORIES (Name) VALUES ('Politics')");


            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
