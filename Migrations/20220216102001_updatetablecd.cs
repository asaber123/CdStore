using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cdStore.Migrations
{
    public partial class updatetablecd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CdUser");

            migrationBuilder.AddColumn<int>(
                name: "CdId",
                table: "User",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_CdId",
                table: "User",
                column: "CdId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Cd_CdId",
                table: "User",
                column: "CdId",
                principalTable: "Cd",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Cd_CdId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_CdId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CdId",
                table: "User");

            migrationBuilder.CreateTable(
                name: "CdUser",
                columns: table => new
                {
                    CdId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CdUser", x => new { x.CdId, x.UserId });
                    table.ForeignKey(
                        name: "FK_CdUser_Cd_CdId",
                        column: x => x.CdId,
                        principalTable: "Cd",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CdUser_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CdUser_UserId",
                table: "CdUser",
                column: "UserId");
        }
    }
}
