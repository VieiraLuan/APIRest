using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TemplateData.Migrations
{
    public partial class Insertingdefaultuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "usuario",
                columns: new[] { "Id", "Email", "Nome" },
                values: new object[] { new Guid("21bf7346-e5ec-4291-bb7b-ea4ba66506bb"), "Usuariopadra@projeto.com", "Usuario Padrão" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("21bf7346-e5ec-4291-bb7b-ea4ba66506bb"));
        }
    }
}
