using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.MVC.Database.Migrations
{
    public partial class MoreDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BookPdfUri",
                table: "Books",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Books",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CoverImageUri",
                table: "Books",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Books",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Books",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TotalPages",
                table: "Books",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "Books",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookPdfUri",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "CoverImageUri",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "TotalPages",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Books");
        }
    }
}
