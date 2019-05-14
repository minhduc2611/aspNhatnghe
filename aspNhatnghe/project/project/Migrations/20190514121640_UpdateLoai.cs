using Microsoft.EntityFrameworkCore.Migrations;

namespace project.Migrations
{
    public partial class UpdateLoai : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loai_Loai_LoaiChaMaLoai",
                table: "Loai");

            migrationBuilder.DropIndex(
                name: "IX_Loai_LoaiChaMaLoai",
                table: "Loai");

            migrationBuilder.DropColumn(
                name: "LoaiChaMaLoai",
                table: "Loai");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LoaiChaMaLoai",
                table: "Loai",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Loai_LoaiChaMaLoai",
                table: "Loai",
                column: "LoaiChaMaLoai");

            migrationBuilder.AddForeignKey(
                name: "FK_Loai_Loai_LoaiChaMaLoai",
                table: "Loai",
                column: "LoaiChaMaLoai",
                principalTable: "Loai",
                principalColumn: "MaLoai",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
