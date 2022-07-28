using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TemplateData.Migrations
{
    public partial class Fieldemailinusertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "usuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "usuario");
        }
    }
}
