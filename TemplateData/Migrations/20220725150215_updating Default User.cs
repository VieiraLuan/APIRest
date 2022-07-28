using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TemplateData.Migrations
{
    public partial class updatingDefaultUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("21bf7346-e5ec-4291-bb7b-ea4ba66506bb"),
                column: "DateCreated",
                value: new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("21bf7346-e5ec-4291-bb7b-ea4ba66506bb"),
                column: "DateCreated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
