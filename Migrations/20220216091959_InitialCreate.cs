using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cdStore.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cd",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CdName = table.Column<string>(type: "TEXT", nullable: true),
                    Artist = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cd", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Artist",
                columns: table => new
                {
                    ArtistId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ArtistName = table.Column<string>(type: "TEXT", nullable: true),
                    ArtistOrigin = table.Column<string>(type: "TEXT", nullable: true),
                    CdId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.ArtistId);
                    table.ForeignKey(
                        name: "FK_Artist_Cd_CdId",
                        column: x => x.CdId,
                        principalTable: "Cd",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artist_CdId",
                table: "Artist",
                column: "CdId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artist");

            migrationBuilder.DropTable(
                name: "Cd");
        }
    }
}
