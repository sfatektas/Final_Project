using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MSS_NewsWeb.Data.Migrations
{
    public partial class UserConfUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "AppUsers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_AppUsers_Username",
                table: "AppUsers",
                column: "Username");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_AppUsers_Username",
                table: "AppUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
