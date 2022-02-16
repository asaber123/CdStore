using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cdStore.Migrations
{
    public partial class updatetable3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cd_Artist_ArtistId",
                table: "Cd");

            migrationBuilder.DropForeignKey(
                name: "FK_Cd_User_UserId",
                table: "Cd");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Cd",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "ArtistId",
                table: "Cd",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "ArtistName",
                table: "Cd",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserName",
                table: "Cd",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Cd_Artist_ArtistId",
                table: "Cd",
                column: "ArtistId",
                principalTable: "Artist",
                principalColumn: "ArtistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cd_User_UserId",
                table: "Cd",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cd_Artist_ArtistId",
                table: "Cd");

            migrationBuilder.DropForeignKey(
                name: "FK_Cd_User_UserId",
                table: "Cd");

            migrationBuilder.DropColumn(
                name: "ArtistName",
                table: "Cd");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Cd");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Cd",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ArtistId",
                table: "Cd",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cd_Artist_ArtistId",
                table: "Cd",
                column: "ArtistId",
                principalTable: "Artist",
                principalColumn: "ArtistId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cd_User_UserId",
                table: "Cd",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
