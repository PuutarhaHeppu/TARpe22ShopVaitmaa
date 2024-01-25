using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TARpe22ShopVaitmaa.Data.Migrations
{
    public partial class ehntuihgi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaidenLaunch",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "Manufacturer",
                table: "Cars",
                newName: "Mark");

            migrationBuilder.RenameColumn(
                name: "FullTripsCount",
                table: "Cars",
                newName: "km");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "km",
                table: "Cars",
                newName: "FullTripsCount");

            migrationBuilder.RenameColumn(
                name: "Mark",
                table: "Cars",
                newName: "Manufacturer");

            migrationBuilder.AddColumn<DateTime>(
                name: "MaidenLaunch",
                table: "Cars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
