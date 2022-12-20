﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RenkliRuyalarOteli.DAL.Migrations
{
    /// <inheritdoc />
    public partial class kullniciImagePathEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Kullanicilar",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Kullanicilar");
        }
    }
}
