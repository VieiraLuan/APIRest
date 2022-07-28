using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TemplateData.Migrations
{
    public partial class commonfields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "usuario",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "usuario",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "usuario");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "usuario");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "usuario");
        }
    }
}
