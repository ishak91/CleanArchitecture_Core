using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.EntityFramework.Migrations
{
    public partial class InitialDbSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entity1Table",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Prop1 = table.Column<string>(nullable: true),
                    Prop2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entity1Table", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entity2Table",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Prop1 = table.Column<string>(nullable: true),
                    Prop2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entity2Table", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entity1Table");

            migrationBuilder.DropTable(
                name: "Entity2Table");
        }
    }
}
