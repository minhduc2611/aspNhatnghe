using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace project.Migrations
{
    public partial class quatang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuaTang",
                columns: table => new
                {
                    QuaTangId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenQua = table.Column<string>(nullable: true),
                    MoTa = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    HanDung = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuaTang", x => x.QuaTangId);
                });

            migrationBuilder.CreateTable(
                name: "NhanQua",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaQT = table.Column<int>(nullable: false),
                    MaHh = table.Column<int>(nullable: false),
                    MaKh = table.Column<string>(nullable: true),
                    NgayNhan = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanQua", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhanQua_HangHoa_MaHh",
                        column: x => x.MaHh,
                        principalTable: "HangHoa",
                        principalColumn: "MaHh",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NhanQua_QuaTang_MaQT",
                        column: x => x.MaQT,
                        principalTable: "QuaTang",
                        principalColumn: "QuaTangId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NhanQua_MaHh",
                table: "NhanQua",
                column: "MaHh");

            migrationBuilder.CreateIndex(
                name: "IX_NhanQua_MaQT",
                table: "NhanQua",
                column: "MaQT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NhanQua");

            migrationBuilder.DropTable(
                name: "QuaTang");
        }
    }
}
