﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace project.Migrations
{
    public partial class TenKhongDau : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TenKhongDau",
                table: "Loai",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TenKhongDau",
                table: "HangHoa",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenKhongDau",
                table: "Loai");

            migrationBuilder.DropColumn(
                name: "TenKhongDau",
                table: "HangHoa");
        }
    }
}
