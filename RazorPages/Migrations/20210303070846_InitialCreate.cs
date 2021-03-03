using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPages.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "Movie",
                table => new
                {
                    ID = table.Column<int>("INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>("TEXT", nullable: true),
                    ReleaseDate = table.Column<DateTime>("TEXT", nullable: false),
                    Genre = table.Column<string>("TEXT", nullable: true),
                    Price = table.Column<decimal>("decimal(18, 2)", nullable: false),
                    Rating = table.Column<string>("TEXT", nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Movie", x => x.ID); });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "Movie");
        }
    }
}