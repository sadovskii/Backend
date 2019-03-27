using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.DAL.Migrations
{
    public partial class update33 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users11",
                table: "Users11");

            migrationBuilder.RenameTable(
                name: "Users11",
                newName: "Users22");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users22",
                table: "Users22",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users22",
                table: "Users22");

            migrationBuilder.RenameTable(
                name: "Users22",
                newName: "Users11");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users11",
                table: "Users11",
                column: "Id");
        }
    }
}
