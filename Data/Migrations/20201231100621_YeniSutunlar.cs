using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProje1.Data.Migrations
{
    public partial class YeniSutunlar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Foto",
                table: "Brans",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Tarih",
                table: "Antrenman",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Brans");

            migrationBuilder.DropColumn(
                name: "Tarih",
                table: "Antrenman");
        }
    }
}
