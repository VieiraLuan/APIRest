using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TemplateData.Migrations
{
    public partial class GlobalDataConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "usuario",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 27, 14, 50, 58, 125, DateTimeKind.Local).AddTicks(1086),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "usuario",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "usuario",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 27, 14, 50, 58, 125, DateTimeKind.Local).AddTicks(1086));
        }
    }
}
