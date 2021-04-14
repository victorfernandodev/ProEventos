using Microsoft.EntityFrameworkCore.Migrations;

namespace ProEventos.API.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Locale = table.Column<string>(type: "TEXT", nullable: true),
                    EventDate = table.Column<string>(type: "TEXT", nullable: true),
                    Theme = table.Column<string>(type: "TEXT", nullable: true),
                    AmountPeople = table.Column<int>(type: "INTEGER", nullable: false),
                    Lot = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
