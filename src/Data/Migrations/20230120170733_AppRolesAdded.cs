using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MSS_NewsWeb.Data.Migrations
{
    public partial class AppRolesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_AppRole_AppRoleId",
                table: "AppUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRole",
                table: "AppRole");

            migrationBuilder.RenameTable(
                name: "AppRole",
                newName: "AppRoles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRoles",
                table: "AppRoles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_AppRoles_AppRoleId",
                table: "AppUsers",
                column: "AppRoleId",
                principalTable: "AppRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_AppRoles_AppRoleId",
                table: "AppUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRoles",
                table: "AppRoles");

            migrationBuilder.RenameTable(
                name: "AppRoles",
                newName: "AppRole");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRole",
                table: "AppRole",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_AppRole_AppRoleId",
                table: "AppUsers",
                column: "AppRoleId",
                principalTable: "AppRole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
