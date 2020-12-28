using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProje1.Data.Migrations
{
    public partial class TemelTablolar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Antrenor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AntrenorId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Antrenor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BransAd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Antrenman",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AntrenmanAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sure = table.Column<int>(type: "int", nullable: true),
                    EtkiBolgesi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KapakFoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Video = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BransId = table.Column<int>(type: "int", nullable: false),
                    AntrenorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Antrenman", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Antrenman_Antrenor_AntrenorId",
                        column: x => x.AntrenorId,
                        principalTable: "Antrenor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Antrenman_Brans_BransId",
                        column: x => x.BransId,
                        principalTable: "Brans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Antrenman_AntrenorId",
                table: "Antrenman",
                column: "AntrenorId");

            migrationBuilder.CreateIndex(
                name: "IX_Antrenman_BransId",
                table: "Antrenman",
                column: "BransId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Antrenman");

            migrationBuilder.DropTable(
                name: "Antrenor");

            migrationBuilder.DropTable(
                name: "Brans");
        }
    }
}
