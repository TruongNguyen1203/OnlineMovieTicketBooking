using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class CreateObjectv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "AppUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_MemberId",
                table: "AppUsers",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_Members_MemberId",
                table: "AppUsers",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_Members_MemberId",
                table: "AppUsers");

            migrationBuilder.DropIndex(
                name: "IX_AppUsers_MemberId",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "AppUsers");
        }
    }
}
