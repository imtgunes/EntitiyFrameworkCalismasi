using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntitiyFrameworkCalismasi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "fakulte",
                columns: table => new
                {
                    fakulteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fakulteAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fakulte", x => x.fakulteId);
                });

            migrationBuilder.CreateTable(
                name: "Bolum",
                columns: table => new
                {
                    bolumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bolumAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fakulteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolum", x => x.bolumId);
                    table.ForeignKey(
                        name: "FK_Bolum_fakulte_fakulteId",
                        column: x => x.fakulteId,
                        principalTable: "fakulte",
                        principalColumn: "fakulteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ogrenci",
                columns: table => new
                {
                    ogrenciId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ogrenciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ogrenciSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kimlikNo = table.Column<int>(type: "int", nullable: false),
                    ogrenciNo = table.Column<int>(type: "int", nullable: false),
                    telefonNo = table.Column<int>(type: "int", nullable: false),
                    adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    donem = table.Column<int>(type: "int", nullable: false),
                    sinif = table.Column<int>(type: "int", nullable: false),
                    dogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    girisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    bolumId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ogrenci", x => x.ogrenciId);
                    table.ForeignKey(
                        name: "FK_ogrenci_Bolum_bolumId",
                        column: x => x.bolumId,
                        principalTable: "Bolum",
                        principalColumn: "bolumId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bolum_fakulteId",
                table: "Bolum",
                column: "fakulteId");

            migrationBuilder.CreateIndex(
                name: "IX_ogrenci_bolumId",
                table: "ogrenci",
                column: "bolumId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ogrenci");

            migrationBuilder.DropTable(
                name: "Bolum");

            migrationBuilder.DropTable(
                name: "fakulte");
        }
    }
}
