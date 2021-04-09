using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class ModifyFood : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "Foods");

            migrationBuilder.AddColumn<string>(
                name: "Desciption",
                table: "Foods",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Desciption",
                table: "Foods");

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Foods",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
